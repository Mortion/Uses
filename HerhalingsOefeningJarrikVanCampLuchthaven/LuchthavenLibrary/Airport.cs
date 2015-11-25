using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuchthavenLibrary
{
    public class Airport
    {
        public String Location { get; set; }
        public String Name { get; set; }

        public Airport(String Location,String Name)
        {
            this.Location = Location;
            this.Name = Name;
        }
        public Airport()
        {
            this.Location = "";
            this.Name = "";
        }

        public override string ToString()
        {
            return this.Name + " -- " + this.Location;
        }

    }
}
