using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
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
        const int fadetime = 2;
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(20);
            timer.Tick += Timer_Elapsed;
            timer.Start();

            DoubleAnimation animation1 = new DoubleAnimation();
            DoubleAnimation animation2 = new DoubleAnimation();
            DoubleAnimation animation3 = new DoubleAnimation();

            animation1.From = 0;
            animation1.To = 1;

            animation2.From = 0;
            animation2.To = 1;

            animation3.From = 0;
            animation3.To = 1;

            animation1.Duration = TimeSpan.FromSeconds(fadetime);
            animation2.Duration = TimeSpan.FromSeconds(fadetime);
            animation3.Duration = TimeSpan.FromSeconds(fadetime);

            animation1.BeginTime = TimeSpan.FromSeconds(1);
            animation2.BeginTime = TimeSpan.FromSeconds(7);
            animation3.BeginTime = TimeSpan.FromSeconds(14);

            animation1.AutoReverse = true;
            animation2.AutoReverse = true;
            animation3.AutoReverse = true;

            label1.BeginAnimation(Label.OpacityProperty, animation1);
            label2.BeginAnimation(Label.OpacityProperty, animation2);
            label3.BeginAnimation(Label.OpacityProperty, animation3);


        }

        private void Timer_Elapsed(object sender, EventArgs e)
        {
            DoubleAnimation animation1 = new DoubleAnimation();
            DoubleAnimation animation2 = new DoubleAnimation();
            DoubleAnimation animation3 = new DoubleAnimation();

            animation1.From = 0;
            animation1.To = 1;

            animation2.From = 0;
            animation2.To = 1;

            animation3.From = 0;
            animation3.To = 1;

            animation1.Duration = TimeSpan.FromSeconds(fadetime);
            animation2.Duration = TimeSpan.FromSeconds(fadetime);
            animation3.Duration = TimeSpan.FromSeconds(fadetime);

            animation1.BeginTime = TimeSpan.FromSeconds(1);
            animation2.BeginTime = TimeSpan.FromSeconds(7);
            animation3.BeginTime = TimeSpan.FromSeconds(14);


            //animation1.RepeatBehavior = new RepeatBehavior(TimeSpan.FromSeconds(15));
            //animation2.RepeatBehavior = new RepeatBehavior(TimeSpan.FromSeconds(20));
            //animation3.RepeatBehavior = new RepeatBehavior(TimeSpan.FromSeconds(25));

            //animation1.RepeatBehavior = RepeatBehavior.Forever;
            //animation2.RepeatBehavior = RepeatBehavior.Forever;
            //animation3.RepeatBehavior = RepeatBehavior.Forever;

            animation1.AutoReverse = true;
            animation2.AutoReverse = true;
            animation3.AutoReverse = true;

            label1.BeginAnimation(Label.OpacityProperty, animation1);
            label2.BeginAnimation(Label.OpacityProperty, animation2);
            label3.BeginAnimation(Label.OpacityProperty, animation3);
        }
    }
}
