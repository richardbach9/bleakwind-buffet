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
using System.ComponentModel;
using BleakwindBuffet.Data;
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for Counter.xaml
    /// </summary>
    public partial class Counter : UserControl
    {
        public event EventHandler<CounterEventArgs> Pick;
        public int count = 0;
        public Counter()
        {
            InitializeComponent();
            DataContext = count;
            text.Text = count + "";
        }

        public void Plus(object sender, RoutedEventArgs e)
        {
            count++;
            text.Text = count + "";
            Pick?.Invoke(this, new CounterEventArgs("plus"));
            minusButton.IsEnabled = true;
        }
        public void Minus(object sender, RoutedEventArgs e)
        {
            if(count > 0)
            {
                count--;
            }
            if(count == 0)
            {
                minusButton.IsEnabled = false;
            }
            text.Text = count + "";
            Pick?.Invoke(this, new CounterEventArgs("minus"));
        }
    }
}
