using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Wpf_Lab2_ass1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void bt_perc(object sender, RoutedEventArgs e)
        {
            operate.Text = "  %";
            //Calcview.Text;
        }

        private void bt_zero(object sender, RoutedEventArgs e)
        {
            Calcview.Text += "0";
        }
        private void bt_o(object sender, RoutedEventArgs e)
        {
            Calcview.Text += "1";
        }
        private void bt_two(object sender, RoutedEventArgs e)
        {
            Calcview.Text += "2";
        }
        private void bt_tree(object sender, RoutedEventArgs e)
        {
            Calcview.Text += "3";
        }
        private void bt_for(object sender, RoutedEventArgs e)
        {
            Calcview.Text += "4";
        }
        private void bt_five(object sender, RoutedEventArgs e)
        {
            Calcview.Text += "5";
        }
        private void bt_six(object sender, RoutedEventArgs e)
        {
            Calcview.Text += "6";
        }
        private void bt_sev(object sender, RoutedEventArgs e)
        {
            Calcview.Text += "7";
        }
        private void bt_eig(object sender, RoutedEventArgs e)
        {
            Calcview.Text += "8";
        }
        private void bt_nine(object sender, RoutedEventArgs e)
        {
            Calcview.Text += "9";
        }
        private void bt_dot(object sender, RoutedEventArgs e)
        {
            if(!Calcview.Text.Contains("."))
                            Calcview.Text += ".";
        }
    }
}
