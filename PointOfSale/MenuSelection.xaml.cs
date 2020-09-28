/*
 * Author: Richard Bach
 * Class name: MenuSelection.xaml.cs
 * Purpose: Controls the interaction logic for the MenuSelection user control
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
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data;
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuSelection.xaml
    /// </summary>
    public partial class MenuSelection : UserControl
    {
        Border mw;
        OrderList orderList;
        List<IOrderItem> order;
        /// <summary>
        /// The Constructor for the MenuSelection User Control
        /// </summary>
        /// <param name="list">A list containing the menu items selected by the user</param>
        /// <param name="b">The border from the MainWindow that displays various menus</param>
        /// <param name="ol">An instantiation of the ordered list user control in order to modify it from within other user controls</param>
        public MenuSelection(List<IOrderItem> list, Border b, OrderList ol)
        {
            InitializeComponent();
            order = list;
            mw = b;
            orderList = ol;
        }
        /// <summary>
        /// Displays a customization screen for each respective menu item based on the button pressed
        /// </summary>
        /// <param name="sender">The button pressed</param>
        /// <param name="e">Reference</param>
        void Add(object sender, RoutedEventArgs e)
        {
            Button but = sender as Button;
            switch(but.Name)
            {
                case "buttonBriarheartBurger":
                    mw.Child = new AddBriarheartBurger(order, mw, orderList);
                    break;
                case "buttonAretinoAppleJuice":
                    mw.Child = new AddAretinoAppleJuice(order, mw, orderList);
                    break;
                case "buttonCandlehearthCoffee":
                    mw.Child = new AddCandlehearthCoffee(order, mw, orderList);
                    break;
                case "buttonDoubleDraugr":
                    mw.Child = new AddDoubleDraugr(order, mw, orderList);
                    break;
                case "buttonDragonbornWaffleFries":
                    mw.Child = new AddDragonbornWaffleFries(order, mw, orderList);
                    break;
                case "buttonFriedMiraak":
                    mw.Child = new AddFriedMiraak(order, mw, orderList);
                    break;
                case "buttonGardenOrcOmelette":
                    mw.Child = new AddGardenOrcOmelette(order, mw, orderList);
                    break;
                case "buttonMadOtarGrits":
                    mw.Child = new AddMadOtarGrits(order, mw, orderList);
                    break;
                case "buttonMarkarthMilk":
                    mw.Child = new AddMarkarthMilk(order, mw, orderList);
                    break;
                case "buttonPhillyPoacher":
                    mw.Child = new AddPhillyPoacher(order, mw, orderList);
                    break;
                case "buttonSailorSoda":
                    mw.Child = new AddSailorSoda(order, mw, orderList);
                    break;
                case "buttonSmokehouseSkeleton":
                    mw.Child = new AddSmokehouseSkeleton(order, mw, orderList);
                    break;
                case "buttonThalmorTriple":
                    mw.Child = new AddThalmorTriple(order, mw, orderList);
                    break;
                case "buttonThugsTBone":
                    mw.Child = new AddThugsTBone(order, mw, orderList);
                    break;
                case "buttonVokunSalad":
                    mw.Child = new AddVokunSalad(order, mw, orderList);
                    break;
                case "buttonWarriorWater":
                    mw.Child = new AddWarriorWater(order, mw, orderList);
                    break;
            }
        }
    }
}
