using LuchthavenLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerhalingsOefeningJarrikVanCampLuchthaven
{
    public partial class frmReservationManagement : Form
    {
        public frmReservationManagement(List<Passenger>passengers, Flight Flight)
        {
            InitializeComponent();
            this.Passengers = passengers;
            this.Flight = Flight;
            txtVluchtnummer.Text = Flight.CallSign;
            txtDeparture.Text = Flight.Departure.ToString();
            txtDestination.Text = Flight.Destination.ToString();
            dtTakeOffTime.Value = Flight.TakeOffTime;
            txtAirplane.Text = Flight.Airplane.ToString();
            txtCurrentReservations.Text = Flight.Reservations.Count.ToString();
            txtMaxNumberOfPassengers.Text = Flight.Airplane.NumberOfSeats.ToString();

            foreach (Passenger passenger in Passengers)
            {
                lstPassengers.Items.Add(passenger);
            }
        }

        public Flight Flight { get; set; }
        private List<Passenger> Passengers;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (int pass in lstPassengers.SelectedIndices)
            {
                Flight.AddReservation(Passengers[pass]);
            } 
       }
    }
}
