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

            animation1.From = 1;
            animation1.To = 0;

            animation2.From = 0;
            animation2.To = 1;

            animation3.From = 0;
            animation3.To = 1;

            animation1.Duration = TimeSpan.FromSeconds(3);
            animation2.Duration = TimeSpan.FromSeconds(6);
            animation3.Duration = TimeSpan.FromSeconds(9);

            animation1.AutoReverse = true;
            animation2.AutoReverse = true;
            animation3.AutoReverse = true;


            MyRectangle.BeginAnimation(Label.OpacityProperty, animation1);
            MyRectangle2.BeginAnimation(Label.OpacityProperty, animation2);
            MyRectangle3.BeginAnimation(Label.OpacityProperty, animation3);
        }



    }
}
