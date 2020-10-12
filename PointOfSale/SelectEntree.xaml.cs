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
    /// Interaction logic for CreateCombo.xaml
    /// </summary>
    public partial class CreateCombo : UserControl
    {
        Order order;
        Combo combo;
        Border mw;
        OrderList orderList;
        public CreateCombo(Order order, Combo combo, Border mw, OrderList ol)
        {
            InitializeComponent();
            this.order = order;
            this.combo = combo;
            this.mw = mw;
            orderList = ol;
        }
        /// <summary>
        /// Confirms the user's entree choice and moves onto proper customization screen
        /// </summary>
        /// <param name="sender">Button</param>
        /// <param name="e">Event args</param>
        void Add(object sender, RoutedEventArgs e)
        {
            Button but = sender as Button;
            switch (but.Name)
            {
                case "buttonBriarheartBurger":
                    mw.Child = new AddBriarheartBurger(order, combo, mw, orderList);
                    break;
                case "buttonDoubleDraugr":
                    mw.Child = new AddDoubleDraugr(order, combo, mw, orderList);
                    break;
                case "buttonGardenOrcOmelette":
                    mw.Child = new AddGardenOrcOmelette(order, combo, mw, orderList);
                    break;
                case "buttonPhillyPoacher":
                    mw.Child = new AddPhillyPoacher(order, combo, mw, orderList);
                    break;
                case "buttonSmokehouseSkeleton":
                    mw.Child = new AddSmokehouseSkeleton(order, combo, mw, orderList);
                    break;
                case "buttonThalmorTriple":
                    mw.Child = new AddThalmorTriple(order, combo, mw, orderList);
                    break;
                case "buttonThugsTBone":
                    mw.Child = new AddThugsTBone(order, combo, mw, orderList);
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
