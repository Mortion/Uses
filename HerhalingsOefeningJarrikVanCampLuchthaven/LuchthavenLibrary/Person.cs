using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuchthavenLibrary
{
    public class Person
    {
        public event EventHandler BirthdateInFuture;
        public DateTime Birthdate
        {
            get;
            set;
        }
        public String Firstname
        {
            get;
            set;
        }
        public Gender Gender
        {
            get;
            set;
        }
        public String Name
        {
            get;
            set;
        }

        public Person()
        {
            this.Birthdate = new DateTime(1900, 1, 1);
            this.Firstname = "";
            this.Name = "";
            this.Gender = Gender.Unknown;
        }

        public Person(DateTime Birthdate, string Firstname, string Name, Gender Gender)
        {
            this.Birthdate = Birthdate;
            this.Firstname = Firstname;
            this.Name = Name;
            this.Gender = Gender;
        }
        
        //TODO: Make Event
      
        private void OnBirthdateInFuture()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return this.Name+","+this.Firstname+" - "+this.Birthdate.ToString("dd/mm/yyyy")+" ("+this.Gender+")";
        }



    }
}
