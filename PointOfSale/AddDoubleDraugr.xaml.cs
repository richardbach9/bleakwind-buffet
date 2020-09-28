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
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for AddDoubleDraugr.xaml
    /// </summary>
    public partial class AddDoubleDraugr : UserControl
    {
        List<IOrderItem> order;
        Border b;
        OrderList orderList;
        public AddDoubleDraugr(List<IOrderItem> list, Border mw, OrderList ol)
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
            DoubleDraugr dd = new DoubleDraugr();
            if (checkKetchup.IsChecked == true) dd.Ketchup = true;
            else dd.Ketchup = false;
            if (checkBun.IsChecked == true) dd.Bun = true;
            else dd.Bun = false;
            if (checkMustard.IsChecked == true) dd.Mustard = true;
            else dd.Mustard = false;
            if (checkPickle.IsChecked == true) dd.Pickle = true;
            else dd.Pickle = false;
            if (checkTomato.IsChecked == true) dd.Tomato = true;
            else dd.Tomato = false;
            if (checkLettuce.IsChecked == true) dd.Lettuce = true;
            else dd.Lettuce = false;
            if (checkMayo.IsChecked == true) dd.Mayo = true;
            else dd.Mayo = false;
            order.Add(dd);
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
