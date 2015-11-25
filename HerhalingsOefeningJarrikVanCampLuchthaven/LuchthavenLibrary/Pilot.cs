using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LuchthavenLibrary
{
    public class Pilot : Person
    {    
        public List<Airplane> Airplanetypes
        {
            get;
            set;
        }    
        public Pilot()
            : base()
        {
            this.Airplanetypes = new List<Airplane>();
        }
        public Pilot(DateTime Birthdate, String Firstname, String Name, Gender Gender)
            : base(Birthdate, Firstname, Name, Gender)
        {
            this.Airplanetypes = new List<Airplane>();
        }
        public void AddAirplaneTypeLicense(Airplane airplane)
        {
            this.Airplanetypes.Add(airplane);
        }
        public void RemoveAirplaneTypeLicense(Airplane airplane)
        {
            this.Airplanetypes.Remove(airplane);
        }
        public override string ToString()
        {
            return "Pilot: " +base.ToString();
        }
    }
}
