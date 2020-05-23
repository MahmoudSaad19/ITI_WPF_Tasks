﻿using System;
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
        double first;
        double res;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
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
            if (!Calcview.Text.Contains("."))
                Calcview.Text += ".";
        }

        private void bt_CE(object sender, RoutedEventArgs e)
        {
            Calcview.Text = String.Empty;
        }
        private void bt_C(object sender, RoutedEventArgs e)
        {
            if (Calcview.Text.Length > 0)
                Calcview.Text = Calcview.Text.Substring(0, Calcview.Text.Length - 1);
        }
        private void bt_perc(object sender, RoutedEventArgs e)
        {
            operate.Text = "%";
            first = Double.Parse(Calcview.Text);
            Calcview.Text = "";
        }

        private void bt_div(object sender, RoutedEventArgs e)
        {
            operate.Text = "/";
            first = Double.Parse(Calcview.Text);
            Calcview.Text = "";
        }
        private void bt_add(object sender, RoutedEventArgs e)
        {
            operate.Text = "+";
            first = Double.Parse(Calcview.Text);
            Calcview.Text = "";
        }
        private void bt_sb(object sender, RoutedEventArgs e)
        {
            operate.Text = "-";
            first = Double.Parse(Calcview.Text);
            Calcview.Text = "";
        }
        private void bt_mul (object sender, RoutedEventArgs e)
        {
            operate.Text = "x";
            first = Double.Parse(Calcview.Text);
            Calcview.Text = "";
        }
        private void bt_res(object sender, RoutedEventArgs e)
        {
            switch(operate.Text)
            {
                case "+":
                    res = first + Double.Parse(Calcview.Text);
                    break;
                case "-":
                    res = first - Double.Parse(Calcview.Text);
                    break;
                case "x":
                    res = first * Double.Parse(Calcview.Text);
                    break;
                case "/":
                    res = first / Double.Parse(Calcview.Text);
                    break;
                case "%":
                    res = first % Double.Parse(Calcview.Text);
                    break;
                default:
                    res = 0;
                    break;
            } 
            operate.Text = string.Empty;
            Calcview.Text = res.ToString();
        }
    }
}
