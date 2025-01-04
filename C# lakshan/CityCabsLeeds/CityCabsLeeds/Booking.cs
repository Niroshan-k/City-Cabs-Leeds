using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityCabsLeeds
{
    internal class Booking
    {
        private string vehicleID;
        public string VehicleID
        {
            get { return vehicleID; }
            set { vehicleID = value; }
        }
        private string plateno;
        public string Plateno
        {
            get { return plateno; }
            set { plateno = value; }
        }
        public string bookingID {  get; set; }
        public string pickupLocation { get; set; }
        public string dropoffLocation { get; set; }
        public int Price { get; set; }
        public decimal Distance { get; set; }
    
        public Customer Customer { get; set; }
        public Driver driver { get; set; }
        private DateTime date;
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        private DateTime time;
        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }
        private string payementMethod;
        public string Payementmethod
        {
            get { return payementMethod; }
            set { payementMethod = value; }
        }
        public string Request {  get; set; }
       
        public Booking()
        {
            // Initialize the Vehicle property to avoid NullReferenceException
            //Vehicle = new Vehicle();
            driver = new Driver();
            Customer = new Customer();
        }
        public Booking(string vehicleid,string district,decimal distance,string contact,string license,string orderid,string orderlocation,string orderdestination, int orderprice, string customerid,string driverid,string plateno,DateTime date,DateTime time,string payementmethod,string request)
        {
            bookingID = orderid;
            pickupLocation = orderlocation;
            dropoffLocation = orderdestination;
            Distance = distance;
            Date = date;
            Time = time;
            payementMethod = payementmethod;
            Price = orderprice;
            Request = request;
            this.plateno = plateno;
            vehicleID = vehicleid;

            driver = new Driver
            {
                license = license,
                driverID = driverid,
                contact = contact,
                District = district,
            };

            Customer = new Customer { customerID = customerid };
        }
    }
}
