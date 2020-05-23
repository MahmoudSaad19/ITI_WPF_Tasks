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
            String text = "Name = " + fname.Text + " " + lname.Text + "\nGender = " + gender.Text + "\nAddress = " + address.Text + "\nJob Title = " + job.Text + "\nPhone = " + phone.Text + "\nMobile = " + mobile.Text + "\nEmail = " + email.Text;
            var res = MessageBox.Show(text, "Personal Info", MessageBoxButton.OKCancel);
            if (res.Equals(MessageBoxResult.OK))
            {
                MessageBox.Show("Data Saved Successfuly", "Saving", MessageBoxButton.OK);
            }
        }
    }
}
