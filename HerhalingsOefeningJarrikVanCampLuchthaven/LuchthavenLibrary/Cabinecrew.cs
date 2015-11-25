using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuchthavenLibrary
{
    public class Cabinecrew : Person
    {
        public Cabinecrew()
            : base()
        {

        }

        public Cabinecrew(DateTime Birthdate, String Firstname, String Name, Gender Gender)
            : base(Birthdate, Firstname, Name, Gender)
        {

        }

        public override string ToString()
        {
            return "Cabinecrew: "+ base.ToString();
        }
    }
}
