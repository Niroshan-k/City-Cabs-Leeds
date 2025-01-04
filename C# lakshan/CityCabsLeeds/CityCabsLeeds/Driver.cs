using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityCabsLeeds
{
    internal class Driver : Person
    {
        public string Username { get; set; }
        private string DriverID;
        public string driverID
        {
            get { return DriverID; }
            set { DriverID = value; }
        }
        private string Password;
        public string password
        {
            get { return Password; }
            set { Password = value; }
        }
        public string District { get; set; }
        public string Havevehicle { get; set; }
        private string Vmake;
        public string vmake
        {
            get { return Vmake; }
            set { Vmake = value; }
        }
        private string Vmodel;
        public string vmodel
        {
            get { return Vmodel; }
            set { Vmodel = value; }
        }
        private string Plateno;
        public string plateno
        {
            get { return Plateno; }
            set { Plateno = value; }
        }
        private string Licenseno;
        public string license
        {
            get { return Licenseno; }
            set { Licenseno = value; }
        }
        public string Worktime { get; set; }
        public string available { get; set; }
        public Driver() { }
        public Driver(string driverid, string fname, string lname, string username, string email, string contact, string password, DateTime dob, string gender, string district, string havevehicle, string vmake, string vmodel, string plateno, string driverlicense, string worktime, string available) : base(fname, lname, email, contact, dob, gender)
        {
            DriverID = driverid;
            Username = username;
            Password = password;
            District = district;
            Havevehicle = havevehicle;
            Vmake = vmake;
            Vmodel = vmodel;
            Plateno = plateno;
            Licenseno = driverlicense;
            Worktime = worktime;
            this.available = available;
        }
    }
}
