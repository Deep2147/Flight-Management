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
    /// Interaction logic for CustomerPage.xaml
    /// </summary>
    public partial class CustomerPage : Window
    {



        public CustomerPage()
        {
            InitializeComponent();
            cdis.SelectionMode = SelectionMode.Single;
            Logins currentuser = Logins.getuserdata();
           if(currentuser.Superuser != 1)
            {
                add.IsEnabled = false;
                delete.IsEnabled = false;
                update.IsEnabled = false;
            }
           
            foreach (var x in Customer.clist)
            {
                cdis.Items.Add(x);
            }
            

        }

        

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(cdis.SelectedItem.ToString()))
            {
                MessageBox.Show("Please Select an Item from ListBox");
                return;
            }
            cdis.Items.Remove(cdis.SelectedItem);
            Customer.clist.Remove((Customer)cdis.SelectedItem);

        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(idinp.Text) || String.IsNullOrEmpty(nameinp.Text) || String.IsNullOrEmpty(emailinp.Text))
            {
                MessageBox.Show("Please Fill Out all the Fields");
                return;
            }
            var id = int.Parse(idinp.Text);
            var name = nameinp.Text;
            var email = emailinp.Text;
            var phone = phoneinp.Text;
            var add = addinp.Text;
            Customer cs = new Customer(id, name, email, phone, add);

            Customer.clist.Add(cs);
            cdis.Items.Add(cs);

            idinp.Text="" ;
            nameinp.Text = "";
            emailinp.Text = "";
            phoneinp.Text = "";
            addinp.Text = "";
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            
            if (String.IsNullOrEmpty(cdis.SelectedItem.ToString()))
            {
                MessageBox.Show("Please Select an Item from ListBox");
                return;
            }
            Customer c = (Customer)cdis.SelectedValue;
            int cid = c.ID;
            idinp.Text = cid.ToString();
            nameinp.Text = c.Name;
            emailinp.Text = c.Email;
            phoneinp.Text = c.Phone;
             addinp.Text = c.Address;
            var index = Customer.clist.FindIndex(en => en.ID == cid);

            cdis.Items.Remove(cdis.SelectedItem);

        }

        private void close_app(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Menu m = new Menu();
            m.Show();
        }

        private void save_app(object sender, RoutedEventArgs e)
        {

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
