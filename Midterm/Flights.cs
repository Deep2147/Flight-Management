using System;
using System.Collections.Generic;
using System.Printing;
using System.Security.Policy;
using System.Text;

namespace Midterm
{
    class Flights
    {
        public static List<Flights> flist = new List<Flights>();
        private int id;
        private int airlineId;
        private string departurecity;
        private string destinationcity;
        private string departuredate;
        private double flighttime;

        public Flights()
        {

        }
        public Flights(int id, int airlineId, string departurecity, string destinationcity, string departuredate, double flighttime)
        {
            Id = id;
            AirlineId = airlineId;
            Departurecity = departurecity;
            Destinationcity = destinationcity;
            DepartureDate = departuredate;
            FlightTime = flighttime;

        }
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public int AirlineId
        {
            get { return this.airlineId; }
            set { this.airlineId = value; }
        }

        public string Departurecity
        {
            get { return this.departurecity; }
            set { this.departurecity = value; }
        }
        public string Destinationcity
        {
            get { return this.destinationcity; }
            set { this.destinationcity = value; }
        }
        public string DepartureDate
        {
            get { return this.departuredate; }
            set { this.departuredate = value; }
        }
        public double FlightTime
        {
            get { return this.flighttime; }
            set { this.flighttime = value; }
        }

        
        public override string ToString()
        {
            return Id+",AirlineId:"+AirlineId+",DepartureCity:"+Departurecity+",DestinationCity:"+Destinationcity+",DepartureDate"+DepartureDate+",FlightTime:"+FlightTime;
        }
         
        public static void addflights()
        {
           

            flist.Add(new Flights(1, 1001, "Chicago", "Delhi", "2020-10-20", 48));
            flist.Add(new Flights(2, 1002, "Toronto", "Dubai", "2020-11-23", 24));
            flist.Add(new Flights(3, 1003, "London", "Nigeria", "2020-7-1", 50));
        }
    }
}
