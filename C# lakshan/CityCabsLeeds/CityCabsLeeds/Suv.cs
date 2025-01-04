using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityCabsLeeds
{
    internal class Suv : Vehicle
    {
        public string SuvID { get; set; }
        public Suv(string suvID, string vehiclemake, string vehiclemodel, string plateno, string availability) : base(vehiclemake, vehiclemodel, plateno, availability)
        {
            SuvID = suvID;
        }
    }
}
