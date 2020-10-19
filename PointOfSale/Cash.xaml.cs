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
    /// Interaction logic for Cash.xaml
    /// </summary>
    public partial class Cash : UserControl
    {
        public double owed = 0;
        public double due;
        public double Total;
        OrderList oL;
        Border border;
        Order order;
        public Cash(Order order, Border b, OrderList orderList)
        {
            InitializeComponent();
            total.Text = "------------------ $" + String.Format("{0:0.##}", order.Total);
            Total = order.Total;
            due = order.Total;
            Due.Text = "------------------ $" + String.Format("{0:0.##}", due);
            Owed.Text = "------------------ $" + String.Format("{0:0.##}", owed);
            RoundRegister.CashDrawer.OpenDrawer();
            this.order = order;
            oL = orderList;
            border = b;
        }

        public void FinalizeTransaction(Object sender, RoutedEventArgs e)
        {
            RoundRegister.RecieptPrinter.PrintLine("Order #" + oL.OrderNumber);
            DateTime dt = new DateTime();
            RoundRegister.RecieptPrinter.PrintLine(dt.TimeOfDay + " " + dt.Day + "/" + dt.Month + "/" + dt.Year);
            oL.Order();
            RoundRegister.RecieptPrinter.PrintLine(oL.orderString.Text);
            RoundRegister.RecieptPrinter.PrintLine(oL.subtotalCost.Text);
            RoundRegister.RecieptPrinter.PrintLine(oL.Tax.Text);
            RoundRegister.RecieptPrinter.PrintLine(oL.TotalCost.Text);
            RoundRegister.RecieptPrinter.PrintLine("Payment Method: Cash");
            RoundRegister.RecieptPrinter.PrintLine("Changed Owed: " + String.Format("{0:0.##}", owed));
            RoundRegister.RecieptPrinter.CutTape();
            order = new Order();
            oL.Cancel(sender, e);
            oL.order.Number++;
            oL.Order();
            border.Child = new MenuSelection(order, border, oL);
        }

        void OnCounterPicked(object sender, CounterEventArgs e)
        {
            if (sender is Counter counter)
            {
                switch (counter.Name)
                {
                    case "Counter0":
                        if (!e.AddorSub)
                        {
                            due += 100;
                            RoundRegister.CashDrawer.Hundreds--;
                        }
                        else
                        {
                            due -= 100;
                            RoundRegister.CashDrawer.Hundreds++;
                        }
                        break;
                    case "Counter1":
                        if (!e.AddorSub)
                        {
                            due += 50;
                            RoundRegister.CashDrawer.Fifties--;
                        }
                        else
                        {
                            due -= 50;
                            RoundRegister.CashDrawer.Fifties++;
                        }
                        break;
                    case "Counter2":
                        if (!e.AddorSub)
                        {
                            due += 20;
                            RoundRegister.CashDrawer.Twenties--;
                        }
                        else
                        {
                            due -= 20;
                            RoundRegister.CashDrawer.Twenties++;
                        }
                        break;
                    case "Counter3":
                        if (!e.AddorSub)
                        {
                            due += 10;
                            RoundRegister.CashDrawer.Tens--;
                        }
                        else
                        {
                            due -= 10;
                            RoundRegister.CashDrawer.Tens++;
                        }
                        break;
                    case "Counter4":
                        if (!e.AddorSub)
                        {
                            due += 5;
                            RoundRegister.CashDrawer.Fives--;
                        }
                        else
                        {
                            due -= 5;
                            RoundRegister.CashDrawer.Fives++;
                        }
                        break;
                    case "Counter5":
                        if (!e.AddorSub)
                        {
                            due += 2;
                            RoundRegister.CashDrawer.Twos--;
                        }
                        else
                        {
                            due -= 2;
                            RoundRegister.CashDrawer.Twos++;
                        }
                        break;
                    case "Counter6":
                        if (!e.AddorSub)
                        {
                            due += 1;
                            RoundRegister.CashDrawer.Ones--;
                        }
                        else
                        {
                            due -= 1;
                            RoundRegister.CashDrawer.Ones++;
                        }
                        break;
                    case "Counter7":
                        if (!e.AddorSub)
                        {
                            due += 1;
                            RoundRegister.CashDrawer.Dollars--;
                        }
                        else
                        {
                            due -= 1;
                            RoundRegister.CashDrawer.Dollars++;
                        }
                        break;
                    case "Counter8":
                        if (!e.AddorSub)
                        {
                            due += 0.5;
                            RoundRegister.CashDrawer.HalfDollars--;
                        }
                        else
                        {
                            due -= 0.5;
                            RoundRegister.CashDrawer.HalfDollars++;
                        }
                        break;
                    case "Counter9":
                        if (!e.AddorSub)
                        {
                            due += 0.25;
                            RoundRegister.CashDrawer.Quarters--;
                        }
                        else
                        {
                            due -= 0.25;
                            RoundRegister.CashDrawer.Quarters++;
                        }
                        break;
                    case "Counter10":
                        if (!e.AddorSub)
                        {
                            due += 0.1;
                            RoundRegister.CashDrawer.Dimes--;
                        }
                        else
                        {
                            due -= 0.1;
                            RoundRegister.CashDrawer.Dimes++;
                        }
                        break;
                    case "Counter11":
                        if (!e.AddorSub)
                        {
                            due += 0.05;
                            RoundRegister.CashDrawer.Nickels--;
                        }
                        else
                        {
                            due -= 0.05;
                            RoundRegister.CashDrawer.Nickels++;
                        }
                        break;
                    case "Counter12":
                        if (!e.AddorSub)
                        {
                            due += 0.01;
                            RoundRegister.CashDrawer.Pennies--;
                        }
                        else
                        {
                            due -= 0.01;
                            RoundRegister.CashDrawer.Pennies++;
                        }
                        break;
                }
                if (due < 0)
                {
                    owed = due * -1;
                    Due.Text = "------------------ $" + String.Format("{0:0.##}", 0);
                    Dues();
                }
                else
                {
                    owed = 0;
                    Due.Text = "------------------ $" + String.Format("{0:0.##}", due);
                    Dues();
                }

                Owed.Text = "------------------ $" + String.Format("{0:0.##}", owed);
            }
        }
        void Dues()
        {
            double tempOwed = owed;
            int change;
            if(RoundRegister.CashDrawer.Hundreds > 0 && tempOwed >= 100)
            {
                change = (int)(tempOwed / 100);
                
                if ((int)(tempOwed / 100) > RoundRegister.CashDrawer.Hundreds) change = RoundRegister.CashDrawer.Hundreds;
                Change100.Text = "------------------ " + change;
                tempOwed -= change * 100;
            }
            else
            {
                Change100.Text = "------------------ " + 0;
            }
            if (RoundRegister.CashDrawer.Fifties > 0 && tempOwed >= 50)
            {
                change = (int)(tempOwed / 50);
                
                if ((int)(tempOwed / 50) > RoundRegister.CashDrawer.Fifties) change = RoundRegister.CashDrawer.Fifties;
                Change50.Text = "------------------ " + change;
                tempOwed -= change * 50;
            }
            else
            {
                Change50.Text = "------------------ " + 0;
            }
            if (RoundRegister.CashDrawer.Twenties > 0 && tempOwed >= 20)
            {
                change = (int)(tempOwed / 20);
                
                if ((int)(tempOwed / 20) > RoundRegister.CashDrawer.Twenties) change = RoundRegister.CashDrawer.Twenties;
                Change20.Text = "------------------ " + change;
                tempOwed -= change * 20;
            }
            else
            {
                Change20.Text = "------------------ " + 0;
            }
            if (RoundRegister.CashDrawer.Tens > 0 && tempOwed >= 10)
            {
                change = (int)(tempOwed / 10);
                
                if ((int)(tempOwed / 10) > RoundRegister.CashDrawer.Tens) change = RoundRegister.CashDrawer.Tens;
                Change10.Text = "------------------ " + change;
                tempOwed -= change * 10;
            }
            else
            {
                Change10.Text = "------------------ " + 0;
            }
            if (RoundRegister.CashDrawer.Fives > 0 && tempOwed >= 5)
            {
                change = (int)(tempOwed / 5);
                
                if ((int)(tempOwed / 5) > RoundRegister.CashDrawer.Fives) change = RoundRegister.CashDrawer.Fives;
                Change5.Text = "------------------ " + change;
                tempOwed -= change * 5;
            }
            else
            {
                Change5.Text = "------------------ " + 0;
            }
            if (RoundRegister.CashDrawer.Twos > 0 && tempOwed >= 2)
            {
                change = (int)(tempOwed / 2);
                
                if ((int)(tempOwed / 2) > RoundRegister.CashDrawer.Twos) change = RoundRegister.CashDrawer.Twos;
                Change2.Text = "------------------ " + change;
                tempOwed -= change * 2;
            }
            else
            {
                Change2.Text = "------------------ " + 0;
            }
            if (RoundRegister.CashDrawer.Ones > 0 && tempOwed >= 1)
            {
                change = (int)(tempOwed / 1);
                
                if ((int)(tempOwed / 1) > RoundRegister.CashDrawer.Ones) change = RoundRegister.CashDrawer.Ones;
                Change1.Text = "------------------ " + change;
                tempOwed -= change * 1;
            }
            else
            {
                Change1.Text = "------------------ " + 0;
            }
            if (RoundRegister.CashDrawer.Dollars > 0 && tempOwed >= 1)
            {
                change = (int)(tempOwed / 1);
                
                if ((int)(tempOwed / 1) > RoundRegister.CashDrawer.Dollars) change = RoundRegister.CashDrawer.Dollars;
                Change01.Text = "------------------ " + change;
                tempOwed -= change * 1;
            }
            else
            {
                Change01.Text = "------------------ " + 0;
            }
            if (RoundRegister.CashDrawer.HalfDollars > 0 && tempOwed >= 0.5)
            {
                change = (int)(tempOwed / 0.5);
                
                if ((int)(tempOwed / 0.5) > RoundRegister.CashDrawer.HalfDollars) change = RoundRegister.CashDrawer.HalfDollars;
                Change05.Text = "------------------ " + change;
                tempOwed -= change * 0.5;
            }
            else
            {
                Change05.Text = "------------------ " + 0;
            }
            if (RoundRegister.CashDrawer.Quarters > 0 && tempOwed > 0.25)
            {
                change = (int)(tempOwed / 0.25);
                
                if ((int)(tempOwed / 0.25) > RoundRegister.CashDrawer.Quarters) change = RoundRegister.CashDrawer.Quarters;
                Change025.Text = "------------------ " + change;
                tempOwed -= change * 0.25;
            }
            else
            {
                Change025.Text = "------------------ " + 0;
            }
            if (RoundRegister.CashDrawer.Dimes > 0 && tempOwed > 0.1)
            {
                change = (int)(tempOwed / 0.1);
                
                if ((int)(tempOwed / 0.1) > RoundRegister.CashDrawer.Dimes) change = RoundRegister.CashDrawer.Dimes;
                Change010.Text = "------------------ " + change;
                tempOwed -= change * 0.1;
            }
            else
            {
                Change010.Text = "------------------ " + 0;
            }
            if (RoundRegister.CashDrawer.Nickels > 0 && tempOwed > 0.05)
            {
                change = (int)(tempOwed / 0.05);
                
                if ((int)(tempOwed / 0.05) > RoundRegister.CashDrawer.Nickels) change = RoundRegister.CashDrawer.Nickels;
                Change005.Text = "------------------ " + change;
                tempOwed -= change * 0.05;
            }
            else
            {
                Change005.Text = "------------------ " + 0;
            }
            if (RoundRegister.CashDrawer.Pennies > 0 && tempOwed > 0.01)
            {
                change = (int)(tempOwed / 0.01);
                
                if ((int)(tempOwed / 0.01) > RoundRegister.CashDrawer.Pennies) change = RoundRegister.CashDrawer.Pennies;
                Change001.Text = "------------------ " + change;
                tempOwed -= change * 0.01;
            }
            else
            {
                Change001.Text = "------------------ " + 0;
            }
        }
    }
}
