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
using System.Linq;

namespace Midterm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            // Creating Flight stack
            

            //creating list for Airline

            Passenger.addingdefaultpassenger();
            Customer.addclist();
            Logins.addnewDefault();
            Flights.addflights();

            Airline.defaultairlines();


        }

        

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var user = userbox.Text;
            var pass = passbox.Password;

            var searchuser = from us in Logins.llist
                             where us.Username == user
                             select us;
            foreach(var yz in searchuser)
            {
                Logins.setuserdata(yz);
            }
            if(validateuser(user, pass))
            {
                this.Hide();
                Menu m = new Menu();
                m.Show();
            }
            else
            {
                MessageBox.Show("Invalid LOgin");
            }
          
        }
        public bool validateuser(string username,string password)
        {

            Dictionary<string, string> userlist = new Dictionary<string, string>();

            foreach (var x in Logins.llist)
            {
                userlist.Add(x.Username, x.Password);
            }
            return userlist.Any(entry => entry.Key == username && entry.Value == password);
        }
    }
}

