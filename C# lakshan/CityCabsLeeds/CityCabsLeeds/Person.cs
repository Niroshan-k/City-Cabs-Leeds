using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityCabsLeeds
{
    abstract class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        private string Contact;
        public string contact
        {
            get { return Contact; }
            set { Contact = value; }
        }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public Person() { }
        public Person(string firtname, string lastname, string email, string contact, DateTime dob, string gender)
        {
            Firstname = firtname;
            Lastname = lastname;
            Email = email;
            Contact = contact;
            DOB = dob;
            Gender = gender;
        }
        
    }
}
