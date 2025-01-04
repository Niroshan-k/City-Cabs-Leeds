using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityCabsLeeds
{
    internal class Admin : Person
    {
        private string username;
        public string Username
        {
            get { return username; } set { username = value; }
        }
        private string password;
        public string Password
        {
            get { return password; } set { password = value;}
        }

        public Admin(string username, string firstname, string lastname, string email, string contact, string password, DateTime dob, string gender) : base(firstname, lastname, email, contact, dob, gender)
        {
            this.password = password;
            this.username = username;
        }
    }
}
