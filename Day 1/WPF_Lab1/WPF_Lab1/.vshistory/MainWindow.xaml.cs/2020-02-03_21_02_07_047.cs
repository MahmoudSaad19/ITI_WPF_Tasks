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

namespace WPF_Lab1
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

        private void save(object sender, RoutedEventArgs e)
        {
            Window window = new Window();
            window.Width = 100;
            window.Height = 100;
            window.Content = "Name = " + fname.Text + " " + lname.Text + "\nGender = " + gender.Text + "\nAddress = " + address.Text + "\nJob Title = " + job.Text + "\nPhone = " + phone.Text + "\nMobile = " + mobile.Text + "\nEmail = " + email.Text;
            window.Show();
            window.Activate();
            //window.Activate();
            fname.Text = lname.Text;
        }
    }
}
