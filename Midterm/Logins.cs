using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm
{
    class Logins
    {
        public static List<Logins> llist = new List<Logins>();
           
        private int id;
        private string username;
        private string password;
        private int superuser;
        public static Logins saveuserdata;

        public Logins(int id,string username,string password,int superuser)
        {
            Id = id;
            Username = username;
            Password = password;
            Superuser = superuser;
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public static Logins getuserdata()
        {
           return saveuserdata;
        }
        public static void setuserdata(Logins c)
        {
            saveuserdata = c;
        }

        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }
        public int Superuser
        {
            get { return this.superuser; }
            set { this.superuser = value; }
        }
        public static  void addnewDefault()
        {

            llist.Add(new Logins(1, "deep", "patel", 1));
           llist.Add(new Logins(2, "napster", "patel", 0));
            llist.Add(new Logins(3,"john","modi",0));
            llist.Add(new Logins(4,"justin","1234",0));
            llist.Add(new Logins(5,"tom","mukherjee",0));
           
        }
    }
}
