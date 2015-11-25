
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuchthavenLibrary
{
    public class Flight
    {
        public event EventHandler MaxReservationsReached;

        public event EventHandler SameDepartureDestination;

        public Airport Departure { get; set; }
        public Airport Destination { get; set; }
        public Airplane Airplane { get; set; }
        public String CallSign { get; set; }
        public List<Cabinecrew> Crew { get; set; }
        public List<Pilot> Pilots { get; set; }
        public List<Passenger> Reservations { get; set; }
        public DateTime TakeOffTime { get; set; }


        public Flight(Airport Departure, Airport Destination, Airplane Airplane, String CallSign, DateTime TakeOffTime)
        {
            this.Departure = Departure;
            this.Destination = Destination;
            this.Airplane = Airplane;
            this.CallSign = CallSign;
            this.Crew = new List<Cabinecrew>();
            this.Pilots = new List<Pilot>();
            this.Reservations = new List<Passenger>();
            this.TakeOffTime = TakeOffTime;
        }
        public Flight()
        {
            this.Departure = new Airport();
            this.Destination = new Airport();
            this.Airplane = new Airplane();
            this.CallSign = "";
            this.Crew = new List<Cabinecrew>();
            this.Pilots = new List<Pilot>();
            this.Reservations = new List<Passenger>();
            this.TakeOffTime = DateTime.Now;
        }

        public void AddCrewMember(Cabinecrew crew)
        {
            this.Crew.Add(crew);
        }

        public void AddPilot(Pilot pilots)
        {
            this.Pilots.Add(pilots);

        }
        public void AddReservation(Passenger passengers)
        {
            this.Reservations.Add(passengers);
       
        }

        //TODO:Events!

        private void OnMaxReservationsReached()
        {

        }
        private void OnSameDepartureDestination()
        {

        }

        public override string ToString()
        {
            return this.Destination.ToString() + " / " + this.Departure.ToString() + " / " + this.Airplane.ToString() + " / " + this.CallSign + " / " + this.TakeOffTime.ToString("HH:mm:ss"); 
        }
    }
}
