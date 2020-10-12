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
    /// Interaction logic for SelectDrink.xaml
    /// </summary>
    public partial class SelectDrink : UserControl
    {
        Order order;
        Combo combo;
        Border mw;
        OrderList orderList;
        public SelectDrink(Order list, Combo combo, Border mw, OrderList ol)
        {
            order = list;
            InitializeComponent();
            this.combo = combo;
            this.mw = mw;
            orderList = ol;
        }
        /// <summary>
        /// Confirms the user's drink choice and moves onto proper customization screen
        /// </summary>
        /// <param name="sender">Button</param>
        /// <param name="e">Event args</param>
        void Add(object sender, RoutedEventArgs e)
        {
            Button but = sender as Button;
            switch (but.Name)
            {
                case "buttonAretinoAppleJuice":
                    mw.Child = new AddAretinoAppleJuice(order, combo, mw, orderList);
                    break;
                case "buttonCandlehearthCoffee":
                    mw.Child = new AddCandlehearthCoffee(order, combo, mw, orderList);
                    break;
                case "buttonMarkarthMilk":
                    mw.Child = new AddMarkarthMilk(order, combo, mw, orderList);
                    break;
                case "buttonSailorSoda":
                    mw.Child = new AddSailorSoda(order, combo, mw, orderList);
                    break;
                case "buttonWarriorWater":
                    mw.Child = new AddWarriorWater(order, combo, mw, orderList);
                    break;
            }
        }
        /// <summary>
        /// Sets the MenuSelection border back to MenuSelection
        /// </summary>
        /// <param name="sender">The cancel button</param>
        /// <param name="e">Reference</param>
        void Cancel(object sender, RoutedEventArgs e)
        {
            mw.Child = new MenuSelection(order, mw, orderList);
        }
    }
}
