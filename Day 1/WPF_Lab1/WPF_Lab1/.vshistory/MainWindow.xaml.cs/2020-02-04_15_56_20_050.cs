using System;
using System.Windows;

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
            String text = "Name = " + fname.Text + " " + lname.Text + "\nGender = " + gender.Text + "\nAddress = " + address.Text + "\nJob Title = " + job.Text + "\nPhone = " + phone.Text + "\nMobile = " + mobile.Text + "\nEmail = " + email.Text;
            MessageBox.Show(text);
            window.Width = 200;
            window.Height = 200;
            window.Content = "Name = " + fname.Text + " " + lname.Text + "\nGender = " + gender.Text + "\nAddress = " + address.Text + "\nJob Title = " + job.Text + "\nPhone = " + phone.Text + "\nMobile = " + mobile.Text + "\nEmail = " + email.Text;
            bool? state = window.ShowDialog();
            window.Activate();
            
            if(!state?? false)
            {
                Window window1 = new Window();
                window1.Name = "saving";
                window1.Width = 70;
                window1.Height = 50;
                window1.Content = "Data Saved Successfuly";
            }


        }
    }
}
