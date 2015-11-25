using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuchthavenLibrary
{
    public class Airplane : IMovement
    {
        public String Location { get; set; }
        public String Manufacturer { get; set; }
        public String Model { get; set; }
        public int NumberOfCrew { get; set; }
        public int NumberOfPilots { get; set; }
        public int NumberOfSeats { get; set; }

        public Airplane(String Location,String Manufacturer,String Model,int nrCrew,int nrPilots,int nrSeats)
        {
            this.Location = Location;
            this.Manufacturer = Manufacturer;
            this.Model = Model;
            this.NumberOfCrew = nrCrew;
            this.NumberOfPilots = nrPilots;
            this.NumberOfSeats = nrSeats;
        }
        public Airplane()
        {
            this.Location = "";
            this.Manufacturer = "";
            this.Model = "";
            this.NumberOfCrew = 0;
            this.NumberOfPilots = 0;
            this.NumberOfSeats = 0;
        }
        
        /// <summary>
        /// Called when airplane lands in another country
        /// </summary>
        public void ChangeLocation(String Location)
        {
            this.Location = "Location";
        }

        public override string ToString()
        {
            return this.Model + " - " + this.Manufacturer + " - " + this.Location;
        }


        public void ChangeLocation()
        {
            throw new NotImplementedException();
        }
    }
}
