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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Assignment_2_Simple_Animation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DoubleAnimation animation1 = new DoubleAnimation();
            DoubleAnimation animation2 = new DoubleAnimation();
            DoubleAnimation animation3 = new DoubleAnimation();

            animation1.From = 10;
            animation1.To = (this.Width) - 30;
            animation1.Duration = TimeSpan.FromSeconds(5);
            animation1.AutoReverse = true;


            MyRectangle.BeginAnimation(Rectangle.WidthProperty, animation1);
        }



    }
}
