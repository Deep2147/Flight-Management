using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Midterm
{
    class Airline
    {
        public static Queue<Airline> alist = new Queue<Airline>();
        private int id;
        private string name;
        private string airplane;
        private int seatsav;
        private string mealav;

        public Airline(int id,string name, string airplane,int seatsav,string mealav)
        {
            Id = id;
            Name = name;
            Airplane = airplane;
            Seatsav = seatsav;
            Mealav = mealav;
        }
        public Airline() { }


        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Airplane
        {
            get { return this.airplane; }
            set { this.airplane = value; }
        }
        public int Seatsav
        {
            get { return this.seatsav; }
            set { this.seatsav = value; }
        }
        public string Mealav
        {
            get { return this.mealav; }
            set { this.mealav = value; }
        }

        public override string ToString()
        {
            return "Id:"+Id+"Name:"+Name+"Ariplane"+Airplane+"Seatsav"+Seatsav+"Meals:"+Mealav;
        }

         public static void defaultairlines()
        {
            
            alist.Enqueue(new Airline(1001, "Ethiad", "Boeing-777", 20, "Vegeterian"));
            alist.Enqueue(new Airline(1002, "Emirates", "Airbus-320", 10, "Vegeterian"));
            alist.Enqueue(new Airline(1003, "AirIndia", "Boeing-777", 1, "Non-Vegeterian"));

            
        }
    }
}
