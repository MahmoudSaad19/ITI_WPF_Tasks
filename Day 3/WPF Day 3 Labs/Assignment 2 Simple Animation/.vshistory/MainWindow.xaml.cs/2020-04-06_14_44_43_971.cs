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
            //Make the label visible, starting the storyboard.
            lbl.Visibility = Visibility.Visible;

            DispatcherTimer t = new DispatcherTimer();
            //Set the timer interval to the length of the animation.
            t.Interval = new TimeSpan(0, 0, 5);
            t.Tick += (EventHandler)delegate (object snd, EventArgs ea)
            {
                // The animation will be over now, collapse the label.
                lbl.Visibility = Visibility.Hidden;
                // Get rid of the timer.
                ((DispatcherTimer)snd).Stop();
            };
            t.Start();
        }

    }
}
