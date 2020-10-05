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
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for AddAretinoAppleJuice.xaml
    /// </summary>
    public partial class AddAretinoAppleJuice : UserControl
    {
        List<IOrderItem> order;
        Border b;
        OrderList orderList;

        /// <summary>
        /// Constructor for the AddAretinoAppleJuice user control
        /// </summary>
        /// <param name="list">List containing all menu items selected by the user</param>
        /// <param name="mw">Border from the MainWindow enabling it to be changed from separate user controls</param>
        /// <param name="ol">OrderList instantiation allowing it to be edited from separate user controls</param>
        public AddAretinoAppleJuice(List<IOrderItem> list, Border mw, OrderList ol)
        {
            InitializeComponent();
            order = list;
            b = mw;
            orderList = ol;
            DataContext = new AretinoAppleJuice();
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
            AretinoAppleJuice aaj = DataContext as AretinoAppleJuice;
            if (radioSmall.IsChecked == true) aaj.Size = BleakwindBuffet.Data.Enums.Size.Small;
            else if (radioMedium.IsChecked == true) aaj.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            else if (radioLarge.IsChecked == true) aaj.Size = BleakwindBuffet.Data.Enums.Size.Large;
            order.Add(aaj);
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
