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

namespace Wpf_Lab2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            first.TextChanged += setBackfirst;
            address.TextChanged += setBackaddress;
        }
               
        private void setBackfirst(object sender, TextChangedEventArgs e)
        {
            if (first.Text == String.Empty)
                first.Background = Brushes.Yellow;
            else
                first.Background = Brushes.White;
        }
        private void setBackaddress(object sender, TextChangedEventArgs e)
        {
            if (address.Text == String.Empty)
                address.Background = Brushes.Yellow;
            else
                address.Background = Brushes.White;
        }
    }
}
