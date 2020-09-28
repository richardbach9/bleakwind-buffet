/*
 * Author: Richard Bach
 * Class Name: OrderList.xaml.cs
 * Purpose: Controls the contents of the OrderList user control
 */
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
    /// Interaction logic for OrderList.xaml
    /// </summary>
    public partial class OrderList : UserControl
    {
        List<IOrderItem> order;
        double subtotal;
        string orderStr;
        /// <summary>
        /// The Constructor for the OrderList user control
        /// </summary>
        /// <param name="list">The List containing menu items selected by the user</param>
        public OrderList(List<IOrderItem> list)
        {
            InitializeComponent();
            order = list;
        }
        /// <summary>
        /// Parses through the list and totals the prices of all the menu items. Also calculates the tax on the subtotal as well
        /// as adds the tax to the subtotal to get the total. Modifies the text of the user control to match these calculations.
        /// </summary>
        public void Totals()
        {

            subtotal = 0.00;
            for (int i = 0; i < order.Count; i++)
            {
                subtotal += order[i].Price; 
            }
            subtotalCost.Text = "Subtotal: $" + String.Format("{0:0.##}",subtotal);
            Tax.Text = "Tax: $" + String.Format("{0:0.##}", (subtotal * 0.07));
            TotalCost.Text = "Total: $" + String.Format("{0:0.##}", (subtotal * 1.07));
        }
        /// <summary>
        /// Parses through the list and creates a string containing the ToString() returns of each menu item in the list.
        /// Sets a textbox's text to this string.
        /// </summary>
        public void Order()
        {
            orderStr = "";
            for(int i = 0; i < order.Count; i++)
            {
                orderStr += (order[i].ToString() + "\n");
            }
            orderString.Text = orderStr;
        }
    }
}
