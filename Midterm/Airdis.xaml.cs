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
    /// Interaction logic for Airdis.xaml
    /// </summary>
    public partial class Airdis : Window
    {
        
        public Airdis()
        {
            InitializeComponent();
            Airline a = new Airline();
            Logins currentuser = Logins.getuserdata();
            if (currentuser.Superuser != 1)
            {
                addal.IsEnabled = false;
                delal.IsEnabled = false;
                upal.IsEnabled = false;
            }

            aldisplay.SelectionMode = SelectionMode.Single;
            foreach (var x in Airline.alist)
            {
                aldisplay.Items.Add(x) ;
            }
        }

        private void addal_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(idtb.Text) || String.IsNullOrEmpty(nametb1.Text) || String.IsNullOrEmpty(seatstb.Text))
            {
                MessageBox.Show("Please Fill Out all the Fields");
                return;
            }
            
                int id = int.Parse(idtb.Text);
                var name = nametb1.Text;

                string plsl = "";
                bool isChecked = (bool)aplane.IsChecked;
                if (isChecked)
                    plsl = (string)aplane.Content;
                else
                    plsl = (string)aplane2.Content;


                var seats = int.Parse(seatstb.Text);

                string mealsl = "";
                bool issec = (bool)meal1.IsChecked;
                if (issec)
                    mealsl = (string)meal1.Content;
                else
                    mealsl = (string)meal2.Content;

                Airline a = new Airline(id, name, plsl, seats, mealsl);

                aldisplay.Items.Add(a);
                Airline.alist.Enqueue(a);

            nametb1.Text = "";
            idtb.Text = "";
            seatstb.Text = "";

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void delal_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(aldisplay.SelectedItem.ToString()))
            {
                MessageBox.Show("Please Select an Item from ListBox");
                return;
            }
            aldisplay.Items.Remove(aldisplay.SelectedItem);

        }

        private void exit_click(object sender, RoutedEventArgs e)
        {

            exit_page ep = new exit_page();
            ep.Show();

        }

        private void upal_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(aldisplay.SelectedItem.ToString()))
            {
                MessageBox.Show("Please Select an Item from ListBox");
                return;
            }

            Airline a = (Airline)aldisplay.SelectedItem;
          
            idtb.Text =a.Id.ToString();
            nametb1.Text = a.Name;
            
            string pla = a.Airplane;
            string mla = a.Mealav;
            seatstb.Text = a.Seatsav.ToString();
            if (pla == aplane.Content)
            {
                aplane.IsChecked = true;
                aplane2.IsChecked = false;

            }
            else
            {
                aplane2.IsChecked = true;
                aplane.IsChecked =false;
            }
            if(mla == meal1.Content)
            {
                meal1.IsChecked = true;
                meal2.IsChecked = false;

            }
            else
            {
                meal2.IsChecked = true;
                meal1.IsChecked = false;
            }
            aldisplay.Items.Remove(aldisplay.SelectedItem);
            



        }

        private void menu_click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Menu m = new Menu();
            m.Show();
        }
        private void help_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            About_Me abm = new About_Me();
            abm.Show();
        }
    }
}
