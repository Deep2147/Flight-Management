using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Linq;

namespace Midterm
{
    /// <summary>
    /// Interaction logic for ViewFlights.xaml
    /// </summary>
    public partial class ViewFlights : Window
    {

        public ViewFlights()
        {

            InitializeComponent();

            foreach (var x in Flights.flist)
            {

                flistbox.Items.Add(x);

            }
            Logins currentuser = Logins.getuserdata();
            if (currentuser.Superuser != 1)
            {
                addbtn.IsEnabled = false;
                upbtn.IsEnabled = false;
                btn_del.IsEnabled = false;
            }


            flistbox.SelectionMode = SelectionMode.Single;

        }

        private void addbtn_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(idtb.Text) || String.IsNullOrEmpty(adtb.Text) || String.IsNullOrEmpty(deptb.Text) || String.IsNullOrEmpty(desttb.Text) || String.IsNullOrEmpty(timetb.Text) || String.IsNullOrEmpty(datetb.Text))
            {
                MessageBox.Show("Please Fill Out all the Fields");
                return;
            }
            int id = int.Parse(idtb.Text);
            int airlineid = int.Parse(adtb.Text);
            string deptcity = deptb.Text;
            string destcity = desttb.Text;
            string date = datetb.Text;
            double flightime = double.Parse(timetb.Text);

            Flights f = new Flights(id, airlineid, deptcity, destcity, date, flightime);
            Flights.flist.Add(f);
            flistbox.Items.Add(f);

            idtb.Text = "";
            adtb.Text = "";
            deptb.Text = "";
            desttb.Text = "";
            datetb.Text = "";
            timetb.Text = "";
        }

        private void btn_del_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(flistbox.SelectedItem.ToString()))
            {
                MessageBox.Show("Please Select an Item from ListBox");
                return;
            }
           
            Flights fo = (Flights)flistbox.SelectedItem;
            flistbox.Items.Remove(flistbox.SelectedItem);
            Flights.flist.Remove(fo);
            
        }

        private void upbtn_Click(object sender, RoutedEventArgs e)
        {


            if (String.IsNullOrEmpty(flistbox.SelectedItem.ToString()))
            {
                MessageBox.Show("Please Select an Item from ListBox");
                return;
            }
            Flights fy = (Flights)flistbox.SelectedItem;
            idtb.Text = (fy.Id).ToString();
            adtb.Text = fy.AirlineId.ToString();
            deptb.Text = fy.Departurecity;
            desttb.Text = fy.Destinationcity;
            datetb.Text = fy.DepartureDate;
            timetb.Text = fy.FlightTime.ToString();



            flistbox.Items.Remove(flistbox);
            Flights.flist.Remove(fy);

            
            
        }

        private void backbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Menu m = new Menu();
            m.Show();
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
