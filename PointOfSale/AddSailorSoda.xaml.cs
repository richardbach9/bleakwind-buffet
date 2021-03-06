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
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for AddSailorSoda.xaml
    /// </summary>
    public partial class AddSailorSoda : UserControl
    {
        Order order;
        Border b;
        OrderList orderList;
        Combo combo = null;
        public AddSailorSoda(Order list, Border mw, OrderList ol)
        {
            InitializeComponent();
            order = list;
            b = mw;
            orderList = ol;
            DataContext = new SailorSoda();
        }
        public AddSailorSoda(Order list, Combo combo, Border mw, OrderList ol)
        {
            InitializeComponent();
            this.combo = combo;
            b = mw;
            orderList = ol;
            order = list;
            DataContext = new SailorSoda();
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
            SailorSoda ss = DataContext as SailorSoda;
            if (radioBlackBerry.IsChecked == true) ss.SodaFlavor = SodaFlavor.Blackberry;
            else if (radioCherry.IsChecked == true) ss.SodaFlavor = SodaFlavor.Cherry;
            else if (radioGrapefruit.IsChecked == true) ss.SodaFlavor = SodaFlavor.Grapefruit;
            else if (radioLemon.IsChecked == true) ss.SodaFlavor = SodaFlavor.Lemon;
            else if (radioPeach.IsChecked == true) ss.SodaFlavor = SodaFlavor.Peach;
            else if (radioWatermelon.IsChecked == true) ss.SodaFlavor = SodaFlavor.Watermelon;
            if (radioSmall.IsChecked == true) ss.Size = BleakwindBuffet.Data.Enums.Size.Small;
            else if (radioMedium.IsChecked == true) ss.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            else if (radioLarge.IsChecked == true) ss.Size = BleakwindBuffet.Data.Enums.Size.Large;
            if (combo != null)
            {
                combo.Drink = ss;
                order.Add(combo);
            }
            else order.Add(ss);
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
