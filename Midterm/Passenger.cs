using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace Midterm
{

    class Passenger
    {
        public static Stack<Passenger> plist = new Stack<Passenger>();
        private int id;
        private int customerId;
        private int flightId;

         public Passenger(int id,int customerId,int flightId)
        {
            Id = id;
            CustomerId = customerId;
            FlightId = flightId;
        }
        public Passenger()
        {

        }
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public int CustomerId
        {
            get { return this.customerId; }
            set { this.customerId = value; }
        }
        public int FlightId
        {
            get { return this.flightId; }
            set { this.flightId = value; }
        }
        public override string ToString()
        {
            return "Id:" + Id + "||CustomerId:" + CustomerId + "||FlightId:" + FlightId;
        }

        public static void addingdefaultpassenger()
        {
            
            plist.Push(new Passenger(1, 1, 1));
            plist.Push(new Passenger(2, 2, 2));
            plist.Push(new Passenger(3, 3, 3));

            
        }

    }
}
