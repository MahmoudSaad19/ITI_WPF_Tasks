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

namespace Wpf_Lab1_ass3
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

        private void bt_new(object sender, RoutedEventArgs e)
        {
            //ctx.
        }
        
        private void setColor(object sender, RoutedEventArgs e)
        {
            if (Red.IsChecked ?? false)
                ctx.DefaultDrawingAttributes.Color = Color.FromRgb(255, 0, 0);
            else if (Green.IsChecked ?? false)
                MessageBox.Show(Green.Name);
            else if (Blue.IsChecked ?? false)
                MessageBox.Show(Blue.Name);
            else if (Magenta.IsChecked ?? false)
                MessageBox.Show(Magenta.Name);




            MessageBox.Show(this.Content.ToString());

        }
    }
}
