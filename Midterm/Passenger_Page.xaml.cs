using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Security.Cryptography.Xml;
using System.Security.Cryptography.Pkcs;
using System.DirectoryServices.ActiveDirectory;

namespace Midterm
{
    /// <summary>
    /// Interaction logic for Passenger_Page.xaml
    /// </summary>
    public partial class Passenger_Page : Window
    {
        public Passenger_Page()
        {
            InitializeComponent();
            Logins currentuser = Logins.getuserdata();
            if (currentuser.Superuser != 1)
            {
                addbtn.IsEnabled = false;
                delbtn.IsEnabled = false;
                editbtn.IsEnabled = false;
            }

            var s = from x in Passenger.plist
                    select x;
            foreach (var pp in s)
            {
                displaypass.Items.Add(pp);
            }
            displaypass.SelectionMode = SelectionMode.Single;
        }

        


        private void displaypass_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Passenger p = (Passenger)displaypass.SelectedItem;

            
            var pid = p.CustomerId;
            var customer = from x in Customer.clist
                           join p1 in Passenger.plist 
                          
                           on x.ID equals pid
                           select x;
            var fid = p.FlightId;
            

            foreach (var s in customer)
            {
                cklist.Items.Clear();
                cklist.Items.Add(s);
            }

            var fligtys = from y in Flights.flist
                          join p2 in Passenger.plist
                          on y.Id equals fid
                          select y;

          

            foreach (var fs in fligtys)
            {
                fklist.Items.Clear();
                fklist.Items.Add(fs);
            }
        }

        private void addbtn_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(idtb.Text) || String.IsNullOrEmpty(fttb.Text) || String.IsNullOrEmpty(custtb.Text))
            {
                MessageBox.Show("Please Fill Out all the Fields");
                return;
            }
            
            int id = int.Parse(idtb.Text);
            int fid = int.Parse(fttb.Text);
            int cid = int.Parse(custtb.Text);

            Passenger p = new Passenger(id,fid,cid);
            displaypass.Items.Add(p);
            Passenger.plist.Push(p);

            idtb.Text = "";
            fttb.Text = "";
            custtb.Text = "";
        }

        private void delbtn_Click(object sender, RoutedEventArgs e)
        {

            if (String.IsNullOrEmpty(displaypass.SelectedItem.ToString()))
            {
                MessageBox.Show("Please Select an Item from ListBox");
                return;
            }
            displaypass.Items.Remove(displaypass.SelectedItem);
            
       
        }

        private void backbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void editbtn_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(displaypass.SelectedItem.ToString()))
            {
                MessageBox.Show("Please Select an Item from ListBox");
                return;
            }
            Passenger ps = (Passenger)displaypass.SelectedItem;
            idtb.Text = ps.Id.ToString();
            custtb.Text = ps.CustomerId.ToString();
            fttb.Text = ps.FlightId.ToString();

            displaypass.Items.Remove(displaypass.SelectedItem);


        }
        private void quit_click(object sender, RoutedEventArgs e)
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
