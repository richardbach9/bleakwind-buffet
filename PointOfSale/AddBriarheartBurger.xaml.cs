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
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for AddBriarheartBurger.xaml
    /// </summary>
    public partial class AddBriarheartBurger : UserControl
    {
        Border b;
        List<IOrderItem> order;
        OrderList orderList;
        public AddBriarheartBurger(List<IOrderItem> list, Border mw, OrderList ol)
        {
            InitializeComponent();
            order = list;
            b = mw;
            orderList = ol;
        }
        /// <summary>
        /// Checks each element on the user control and modifies their respective variables to match in the
        /// menu item's properties before adding it to a list and modifying the orderList user control. Sets the MenuSelection
        /// border back to MenuSelection as well.
        /// </summary>
        /// <param name="sender">The button pressed</param>
        /// <param name="e">Reference</param>
        void Done(object sender, RoutedEventArgs e)
        {
            BriarheartBurger bb = new BriarheartBurger();
            if (checkKetchup.IsChecked == true) bb.Ketchup = true;
            else bb.Ketchup = false;
            if (checkBun.IsChecked == true) bb.Bun = true;
            else bb.Bun = false;
            if (checkMustard.IsChecked == true) bb.Mustard = true;
            else bb.Mustard = false;
            if (checkPickle.IsChecked == true) bb.Pickle = true;
            else bb.Pickle = false;
            if (checkCheese.IsChecked == true) bb.Cheese = true;
            else bb.Cheese = false;
            order.Add(bb);
            orderList.Totals();
            orderList.Order();
            b.Child = new MenuSelection(order, b, orderList);
        }
        /// <summary>
        /// Sets the MenuSelection border back to MenuSelection
        /// </summary>
        /// <param name="sender">The cancel button</param>
        /// <param name="e">Reference</param>
        void Cancel(object sender, RoutedEventArgs e)
        {
            b.Child = new MenuSelection(order, b, orderList);
        }
    }
}
