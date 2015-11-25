using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LuchthavenLibrary;
namespace LuchthavenLibrary
{
    public class Passenger : Person
    {
     

        public Passenger():base()
        {
           
        }
        public Passenger(DateTime Birthdate, String Firstname, String Name, Gender Gender)
            : base(Birthdate, Firstname, Name, Gender)
        {
        }
      
        public Passenger(Passenger passenger)
        {
            this.Birthdate = passenger.Birthdate;
            this.Firstname = passenger.Firstname;
            this.Gender = passenger.Gender;
            this.Name = passenger.Name;
      
        }

    

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
