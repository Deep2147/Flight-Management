using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Midterm
{
    /// <summary>
    /// Interaction logic for About_Me.xaml
    /// </summary>
    public partial class About_Me : Window
    {
        public About_Me()
        {
            InitializeComponent();
            aboutext.Text = "This is the Flight Managing Application Which Manages the Customers" +
                "and Flights and getting all the data . \n This is Developed By Deep Patel \t Student Number : 991547214";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Menu m = new Menu();
            m.Show();
        }
    }
}
