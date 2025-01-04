using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityCabsLeeds
{
    internal class Customer : Person
    {
      
        public string Username { get; set; }
        private string CustomerID;
        public string customerID
        {
            get { return CustomerID; }
            set { CustomerID = value; }
        }
        
        private string Password;
        public string password
        {
            get { return Password; }
            set { Password = value; }
        }
        public Customer() { }
        public Customer(string cusid,string firstname,string lastname,string username,string email,string contact,string password,DateTime dob,string gender):base(firstname,lastname,email,contact,dob,gender)
        {
            CustomerID = cusid;
            Username = username;
            Password = password;
        }


    }
}
