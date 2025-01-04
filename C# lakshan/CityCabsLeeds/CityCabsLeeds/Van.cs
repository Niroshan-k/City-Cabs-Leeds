using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityCabsLeeds
{
    internal class Van : Vehicle
    {
        public string VanID { get; set; }
        public Van(string vanID, string vehiclemake, string vehiclemodel, string plateno, string availability) : base(vehiclemake, vehiclemodel, plateno,availability)
        {
            VanID = vanID;
        }
    }
}
