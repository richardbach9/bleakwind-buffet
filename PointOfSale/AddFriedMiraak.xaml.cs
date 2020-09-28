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
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for FriedMiraak.xaml
    /// </summary>
    public partial class AddFriedMiraak : UserControl
    {
        List<IOrderItem> order = new List<IOrderItem>();
        Border b;
        OrderList orderList;
        public AddFriedMiraak(List<IOrderItem> list, Border mw, OrderList ol)
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
            FriedMiraak fm = new FriedMiraak();
            if (radioSmall.IsChecked == true) fm.Size = BleakwindBuffet.Data.Enums.Size.Small;
            else if (radioMedium.IsChecked == true) fm.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            else if (radioLarge.IsChecked == true) fm.Size = BleakwindBuffet.Data.Enums.Size.Large;
            order.Add(fm);
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
