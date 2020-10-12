﻿/*
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
        string orderStr;
        Order order;
        /// <summary>
        /// The Constructor for the OrderList user control
        /// </summary>
        /// <param name="list">The List containing menu items selected by the user</param>
        public OrderList(Order list)
        {
            InitializeComponent();
            DataContext = list;
            order = list;
            OrderNumber.Text = "Order #" + order.Number;
        }
        /// <summary>
        /// Parses through the list and totals the prices of all the menu items. Also calculates the tax on the subtotal as well
        /// as adds the tax to the subtotal to get the total. Modifies the text of the user control to match these calculations.
        /// </summary>
        public void Totals()
        {
            subtotalCost.Text = "Subtotal: $" + String.Format("{0:0.##}", order.Subtotal);
            Tax.Text = "Tax: $" + String.Format("{0:0.##}", order.Tax);
            TotalCost.Text = "Total: $" + String.Format("{0:0.##}", order.Total);
        }
        /// <summary>
        /// Parses through the list and creates a string containing the ToString() returns of each menu item in the list.
        /// Sets a textbox's text to this string.
        /// </summary>
        public void Order()
        {
            orderStr = "";
            for(int i = 0; i < order.list.Count; i++)
            {
                if(order.list[i] is Combo)
                {
                    Combo combo = order.list[i] as Combo;
                    orderStr += ((i + 1) + ". Combo\n" + combo.ToString());
                }
                else
                {
                    orderStr += ((i + 1) + ". " + order.list[i].ToString() + "\n    - $" + String.Format("{0:0.##}", order.list[i].Price) + "\n");
                    for (int j = 0; j < order.list[i].SpecialInstructions.Count; j++)
                    {
                        orderStr += ("    -" + order.list[i].SpecialInstructions[j] + "\n");
                    }
                }
            }
            orderString.Text = orderStr;
        }
        public void Remove(object sender, RoutedEventArgs e)
        {
            if(removeTextBox.Text.Length > 0)
            {
                if(Int32.Parse(removeTextBox.Text) - 1 < order.list.Count)
                {
                    order.Remove(order.list[Int32.Parse(removeTextBox.Text) - 1]);
                }    
            }
            removeTextBox.Text = "";
            Order();
            Totals();
        }
    }
}
