﻿using System;
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
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for AddGardenOrcOmelette.xaml
    /// </summary>
    public partial class AddGardenOrcOmelette : UserControl
    {
        List<IOrderItem> order;
        Border b;
        OrderList orderList;
        public AddGardenOrcOmelette(List<IOrderItem> list, Border mw, OrderList ol)
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
            GardenOrcOmelette goo = new GardenOrcOmelette();
            if (checkBroccoli.IsChecked == true) goo.Broccoli = true;
            else goo.Broccoli = false;
            if (checkMushrooms.IsChecked == true) goo.Mushrooms = true;
            else goo.Broccoli = false;
            if (checkTomato.IsChecked == true) goo.Tomato = true;
            else goo.Tomato = false;
            if (checkCheddar.IsChecked == true) goo.Cheddar = true;
            else goo.Cheddar = false;
            order.Add(goo);
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
