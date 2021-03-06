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
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for AddWarriorWater.xaml
    /// </summary>
    public partial class AddWarriorWater : UserControl
    {
        Order order;
        Border b;
        OrderList orderList;
        Combo combo = null;
        public AddWarriorWater(Order list, Border mw, OrderList ol)
        {
            InitializeComponent();
            order = list;
            b = mw;
            orderList = ol;
        }
        public AddWarriorWater(Order list, Combo combo, Border mw, OrderList ol)
        {
            InitializeComponent();
            this.combo = combo;
            b = mw;
            order = list;
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
            WarriorWater ww = new WarriorWater();
            if (radioSmall.IsChecked == true) ww.Size = BleakwindBuffet.Data.Enums.Size.Small;
            else if (radioMedium.IsChecked == true) ww.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            else if (radioLarge.IsChecked == true) ww.Size = BleakwindBuffet.Data.Enums.Size.Large;
            if (checkIce.IsChecked == true) ww.Ice = true;
            else ww.Ice = false;
            if (combo != null)
            {
                combo.Drink = ww;
                order.Add(combo);
            }
            else order.Add(ww);
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
