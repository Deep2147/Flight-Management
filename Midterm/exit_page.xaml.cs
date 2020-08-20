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
    /// Interaction logic for exit_page.xaml
    /// </summary>
    public partial class exit_page : Window
    {
        public exit_page()
        {
            InitializeComponent();
        }

        private void exitbtn_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void cancelbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
