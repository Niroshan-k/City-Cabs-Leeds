using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityCabsLeeds
{
    internal class Car : Vehicle
    {
        public string CarID { get; set; }
        public string Type { get; set; }
        public Car(string carID, string vehiclemake, string vehiclemodel,string type, string plateno,string availability) : base(vehiclemake, vehiclemodel, plateno, availability)
        {
            CarID = carID;
            Type = type;
        }
    }
}

   

