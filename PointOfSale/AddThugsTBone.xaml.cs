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
    /// Interaction logic for AddThugsTBone.xaml
    /// </summary>
    public partial class AddThugsTBone : UserControl
    {
        Order order;
        Border b;
        OrderList orderList;
        Combo combo = null;
        public AddThugsTBone(Order list, Border mw, OrderList ol)
        {
            InitializeComponent();
            order = list;
            b = mw;
            orderList = ol;
        }
        public AddThugsTBone(Order list, Combo combo, Border mw, OrderList ol)
        {
            InitializeComponent();
            this.combo = combo;
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
            ThugsTBone ttb = new ThugsTBone();
            if (combo != null)
            {
                combo.Entree = ttb;
                orderList.Totals();
                orderList.Order();
                b.Child = new SelectSide(order, combo, b, orderList);
            }
            else
            {
                order.Add(ttb);
                orderList.Totals();
                orderList.Order();
                b.Child = new MenuSelection(order, b, orderList);
            }
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
