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
    public partial class frmFlightManagement : Form
    {
        public frmFlightManagement(List<Airplane> airplanes, List<Airport> airports, List<Pilot> pilots, List<Cabinecrew> crew)
        {
            InitializeComponent();
            this.airplanes = airplanes;
            this.airports = airports;
            this.pilots = pilots;
            this.cabinecrew = crew;

            FillForm();
        }

        public frmFlightManagement(List<Airplane> airplanes, List<Airport> airports, List<Pilot> pilots, List<Cabinecrew> crew, Flight Flight) : base()
        {
            this.Flight = Flight;
            InitializeComponent();
            this.airplanes = airplanes;
            this.airports = airports;
            this.pilots = pilots;
            this.cabinecrew = crew;

            FillForm();
            txtVluchtnummer.Text = Flight.CallSign;
            cbAirplane.SelectedIndex = airplanes.FindIndex(a => a.Model == Flight.Airplane.Model);
            cbDeparture.SelectedIndex = airports.FindIndex(a => a.Name == Flight.Departure.Name);
            cbDestination.SelectedIndex = airports.FindIndex(a => a.Name == Flight.Destination.Name);
            int index = 0;
         
        }

        public Flight Flight { get; set; }
        private List<Airplane> airplanes;
        private List<Airport> airports;
        private List<Pilot> pilots;
        private List<Cabinecrew> cabinecrew;

        private void FillForm()
        {
            foreach (Airplane plane in airplanes)
            {
                cbAirplane.Items.Add(plane.ToString());
            }
            foreach (Airport port in airports)
            {
                cbDeparture.Items.Add(port.ToString());
                cbDestination.Items.Add(port.ToString());
            }

            foreach (Pilot pilot in pilots)
            {
                lstPilots.Items.Add(pilot.ToString());
            }
            foreach (Cabinecrew crew in cabinecrew)
            {
                lstCrew.Items.Add(crew.ToString());
            }
            cbAirplane.SelectedIndex = 0;
            cbDeparture.SelectedIndex = 0;
            cbDestination.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Flight = new Flight(airports[cbDeparture.SelectedIndex], airports[cbDestination.SelectedIndex], airplanes[cbAirplane.SelectedIndex], txtVluchtnummer.Text, dtTakeOffTime.Value);


            foreach (int pilot in lstPilots.SelectedIndices)
            {
                Flight.AddPilot(pilots[pilot]);
            }
            foreach (int crew in lstCrew.SelectedIndices)
            {
                Flight.AddCrewMember(cabinecrew[crew]);
            }
        }
    }
}
