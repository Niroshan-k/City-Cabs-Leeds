using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityCabsLeeds
{
    abstract class Vehicle
    {
        
        public string Vehiclemake {  get; set; } 
        public string Vehiclemodel { get; set; }
        public string PlateNo { get; set; }
        public string availability { get; set; }

        public Vehicle(string vehiclemake, string vehiclemodel, string plateNo, string availability)
        {
            Vehiclemake = vehiclemake;
            Vehiclemodel = vehiclemodel;
            PlateNo = plateNo;
            this.availability = availability;
        }
    }
}
