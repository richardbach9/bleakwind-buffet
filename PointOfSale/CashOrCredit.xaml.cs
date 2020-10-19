using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data;
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashOrCredit.xaml
    /// </summary>
    public partial class CashOrCredit : UserControl
    {
        OrderList oL;
        Border border;
        public CashOrCredit(Order order, Border b, OrderList orderList)
        {
            InitializeComponent();
            DataContext = order;
            border = b;
            oL = orderList;
        }
        public void Cash(object sender, RoutedEventArgs e)
        {
            Order order = DataContext as Order;
            border.Child = new Cash(order, border, oL);
        }
        public void Credit(object sender, RoutedEventArgs e)
        {
            Order order = DataContext as Order;
            switch(RoundRegister.CardReader.RunCard(order.Total))
            {
                case RoundRegister.CardTransactionResult.Approved:
                    RoundRegister.RecieptPrinter.PrintLine("Order #" + oL.OrderNumber);
                    DateTime dt = new DateTime();
                    RoundRegister.RecieptPrinter.PrintLine(dt.TimeOfDay + " " + dt.Day + "/" + dt.Month + "/" + dt.Year);
                    oL.Order();
                    RoundRegister.RecieptPrinter.PrintLine(oL.orderString.Text);
                    RoundRegister.RecieptPrinter.PrintLine(oL.subtotalCost.Text);
                    RoundRegister.RecieptPrinter.PrintLine(oL.Tax.Text);
                    RoundRegister.RecieptPrinter.PrintLine(oL.TotalCost.Text);
                    RoundRegister.RecieptPrinter.PrintLine("Payment Method: Card");
                    RoundRegister.RecieptPrinter.PrintLine("Changed Owed: $0.00");
                    RoundRegister.RecieptPrinter.CutTape();
                    order = new Order();
                    oL.Cancel(sender, e);
                    oL.order.Number++;
                    oL.Order();
                    border.Child = new MenuSelection(order, border, oL);
                    break;
                case RoundRegister.CardTransactionResult.Declined:
                    MessageBox.Show("Declined");
                    break;
                case RoundRegister.CardTransactionResult.InsufficientFunds:
                    MessageBox.Show("Insufficient Funds");
                    break;
                case RoundRegister.CardTransactionResult.IncorrectPin:
                    MessageBox.Show("Incorrect PIN");
                    break;
                case RoundRegister.CardTransactionResult.ReadError:
                    MessageBox.Show("ReadError");
                    break;
            }
        }
    }
}
