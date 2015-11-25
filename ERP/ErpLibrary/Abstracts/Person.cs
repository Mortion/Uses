using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpLibrary
{
    public abstract class Person
    {
        public int  Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }



        protected Person()
        {

        }

        protected Person(string name, string firstName, string email, string address, string city, string postalCode)
        {
            Name = name;
            FirstName = firstName;
            Email = email;
            Address = address;
            City = city;
            PostalCode = postalCode;
        }

        public override string ToString()
        {
            return Name +" "+FirstName ;
        }
    }
}
