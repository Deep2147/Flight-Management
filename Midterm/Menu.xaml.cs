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
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
           Logins user =  Logins.getuserdata();
            if(user.Superuser == 1)
            {
                userbadge.Header = "Superuser";
            }
            else
            {
                userbadge.Header = "Regular User ";
            }

        }

        private void cpage_Click(object sender, RoutedEventArgs e)
        {
            
            this.Hide();
            CustomerPage cp = new CustomerPage();
            cp.Show();
        }

        private void apage_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Airdis ad = new Airdis();
            ad.Show();
        }

        private void ppage_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Passenger_Page ps = new Passenger_Page();
            ps.Show();
        }

        private void fpage_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ViewFlights vf = new ViewFlights();
            vf.Show();
            
        }

        private void exitbtn_Click(object sender, RoutedEventArgs e)
        {
            exit_page ep = new exit_page();
            ep.Show();
        }

        private void help_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            About_Me abm = new About_Me();
            abm.Show();
        }
    }
}
