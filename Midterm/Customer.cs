using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Windows.Navigation;

namespace Midterm
{
    class Customer
    {
        public static List<Customer> clist = new List<Customer>();
        private int id;
        private string name;
        private string address;
        private string email;
        private string phone;
        public Customer() { }
        public int ID
        {
            get {return this.id; }
            set { this.id = value; }
        }
        public string Name
            {
            get { return this.name; }
            set { this.name = value; }

            }
            public string Address {
           get { return this.address; }
            set { this.address = value; } 
        }
            public string Email { get { return this.email; } set { this.email = value; } }
            public string Phone { get { return this.phone; } set { this.phone = value; } }

            public Customer(int id, string name, string address, string email, string phone)
            {
                ID = id;
                Name = name;
                Address = address;
                Email = email;
                Phone = phone;

            }
            public override string ToString()
            {
                return ID + "--Name:" + Name + "--Address:" + Address + "--Email:" + Email + "--Phone:" + Phone;
            }

        public static void addclist()
        {


          
            clist.Add(new Customer(1, "Deep", "Pull st", "deepson2222@gmail.com", "99102002"));
        clist.Add(new Customer(2, "swety", "data st", "deoop22@gmail.com", "90020002"));
            clist.Add(new Customer(3, "napp", "Wpf st", "depatel@gmail.com", "99999999"));
           
        }
        }
    }


