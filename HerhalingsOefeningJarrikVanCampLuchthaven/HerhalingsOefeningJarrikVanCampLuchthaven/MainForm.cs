using LuchthavenLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerhalingsOefeningJarrikVanCampLuchthaven
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region Properties en inits
        private string path = System.AppDomain.CurrentDomain.BaseDirectory.Substring(0, System.AppDomain.CurrentDomain.BaseDirectory.Length - 10);
        private List<Airplane> airplanes;
        private List<Passenger> passengers;
        private List<Pilot> pilots;
        private List<Cabinecrew> cabincrew;
        private List<Flight> Flights;
        private List<Airport> airports;
        private List<Person> fullCrew;


        private void initAirplanes()
        {
            airplanes.Add(new Airplane("België", "Airbus", "SNS-2564", 8, 2, 100));
            airplanes.Add(new Airplane("België", "Airbus", "SNS-5789", 8, 2, 100));
            airplanes.Add(new Airplane("België", "Airbus", "SNS-1222", 8, 2, 100));
            airplanes.Add(new Airplane("België", "Airbus", "SNS-6660", 8, 2, 100));
            airplanes.Add(new Airplane("België", "Airbus", "SNS-8979", 8, 2, 100));
            airplanes.Add(new Airplane("België", "Airbus", "SNS-2133", 8, 2, 100));

            Flights.Add(new Flight(airports[1], airports[2], airplanes[1], "Call 331", DateTime.Now));
            Flights.Add(new Flight(airports[1], airports[0], airplanes[2], "Call 331", DateTime.Now));
        }

        #endregion

        #region Read and write data listboxes
        private void WritePassengers()
        {
            //Todo: Alle writes
            StreamWriter file = new StreamWriter(path + "Databases\\Passengers.txt");

            foreach (Passenger pr in passengers)
            {
                file.WriteLine("");
            }
            file.Close();
        }
        private void ReadPassengers()
        {

            passengers.Clear();


            StreamReader file = new StreamReader(path + "Databases\\Passengers.txt");

            string lijn;
            while ((lijn = file.ReadLine()) != null)
            {
                string[] apart = lijn.Split('|');
                Gender gender;
                switch (apart[3])
                {
                    case "Male":
                        gender = Gender.Male;
                        break;
                    case "Female":
                        gender = Gender.Female;
                        break;

                    default:
                        gender = Gender.Unknown;
                        break;
                }

                Passenger passenger = new Passenger(DateTime.Parse(apart[0]), apart[1], apart[2], gender);
                passengers.Add(passenger);

            }

            file.Close();


        }
        private void ReadPilots()
        {

            pilots.Clear();


            StreamReader file = new StreamReader(path + "Databases\\Pilots.txt");

            string lijn;
            while ((lijn = file.ReadLine()) != null)
            {
                string[] apart = lijn.Split('|');
                Gender gender;
                switch (apart[3])
                {
                    case "Male":
                        gender = Gender.Male;
                        break;
                    case "Female":
                        gender = Gender.Female;
                        break;

                    default:
                        gender = Gender.Unknown;
                        break;
                }

                Pilot pilot = new Pilot(DateTime.Parse(apart[0]), apart[1], apart[2], gender);

                pilots.Add(pilot);

            }

            file.Close();


        }


        private void ReadAirports()
        {

            airports.Clear();


            StreamReader file = new StreamReader(path + "Databases\\Airports.txt");

            string lijn;
            while ((lijn = file.ReadLine()) != null)
            {
                string[] apart = lijn.Split('|');


                Airport airport = new Airport(apart[0], apart[1]);

                airports.Add(airport);

            }

            file.Close();


        }

        private void ReadPlanes()
        {

            airplanes.Clear();


            StreamReader file = new StreamReader(path + "Databases\\Airplanes.txt");

            string lijn;
            while ((lijn = file.ReadLine()) != null)
            {
                string[] apart = lijn.Split('|');


                Airplane airplane = new Airplane(apart[0], apart[1], apart[2], int.Parse(apart[3]), int.Parse(apart[4]), int.Parse(apart[5]));

                airplanes.Add(airplane);

            }

            file.Close();


        }
        private void ReadCrew()
        {
            cabincrew.Clear();
            StreamReader file = new StreamReader(path + "Databases\\Crew.txt");
            string lijn;

            while ((lijn = file.ReadLine()) != null)
            {
                string[] apart = lijn.Split('|');
                Gender gender;
                switch (apart[3])
                {
                    case "Male":
                        gender = Gender.Male;
                        break;
                    case "Female":
                        gender = Gender.Female;
                        break;

                    default:
                        gender = Gender.Unknown;
                        break;
                }
                Cabinecrew crew = new Cabinecrew(DateTime.Parse(apart[0]), apart[1], apart[2], gender);

                cabincrew.Add(crew);
            }
            file.Close();
        }


        private void LoadListboxes()
        {
            lstLuchthaven.Items.Clear();
            lstPassagiers.Items.Clear();
            lstPassagiersVanVlucht.Items.Clear();
            lstPersoneel.Items.Clear();
            lstVluchten.Items.Clear();

            foreach (Passenger passenger in passengers)
            {
                lstPassagiers.Items.Add(passenger.ToString());
            }
            //foreach (Pilot pilot in pilots)
            //{
            //    lstPersoneel.Items.Add(pilot.ToString());
            //}
            //foreach (Cabinecrew crew in cabincrew)
            //{
            //    lstPersoneel.Items.Add(crew.ToString());
            //}
            foreach (Person person in fullCrew)
            {
                lstPersoneel.Items.Add(person.ToString());
            }

            foreach (Airport port in airports)
            {
                lstLuchthaven.Items.Add(port.ToString());
            }
            foreach (Flight flight in Flights)
            {
                lstVluchten.Items.Add(flight.ToString());
            }
        }

        [Conditional("DEBUG")]
        private void ReadAll()
        {
            ReadPassengers();
            ReadPilots();
            ReadCrew();
            ReadPlanes();
            ReadAirports();




        }

        #endregion

        #region Form Load/Closing
        private void MainForm_Load(object sender, EventArgs e)
        {
            //init Lists
            airplanes = new List<Airplane>();
            passengers = new List<Passenger>();
            pilots = new List<Pilot>();
            cabincrew = new List<Cabinecrew>();
            Flights = new List<Flight>();
            airports = new List<Airport>();
            fullCrew = new List<Person>();
            //Read the txt files in Databases
            ReadAll();
            AddFullCrew();
            initAirplanes();

            //Loads the listboxes with data
            LoadListboxes();
        }

        private void AddFullCrew()
        {
            fullCrew.Clear();
            foreach (Pilot pilot in pilots)
            {
                fullCrew.Add(pilot);
            }
            foreach (Cabinecrew cabine in cabincrew)
            {
                fullCrew.Add(cabine);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Todo: write to txts
        }



        #endregion

        #region Add / edit / remove crew
        private void btnToevoegenPersoneel_Click(object sender, EventArgs e)
        {
            frmCrewManagement crewManagement = new frmCrewManagement(airplanes);

            if (crewManagement.ShowDialog() == DialogResult.OK)
            {
                if (crewManagement.isPilot == true)
                {
                    pilots.Add((Pilot)crewManagement.CrewOrPilot);
                }
                else
                {
                    cabincrew.Add((Cabinecrew)crewManagement.CrewOrPilot);
                }

                AddFullCrew();
                lstPersoneel.Items.Clear();
                LoadListboxes();
            }

        }
        private void btnWijzigenPersoneel_Click(object sender, EventArgs e)
        {
            try
            {
                frmCrewManagement crewManagement = new frmCrewManagement(airplanes, true, fullCrew[lstPersoneel.SelectedIndex]);
                if (crewManagement.ShowDialog() == DialogResult.OK)
                {

                    fullCrew[lstPersoneel.SelectedIndex] = crewManagement.CrewOrPilot;


                }

                LoadListboxes();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Select a crewmember!");


            }






        }
        private void btnVerwijderenPersoneel_Click(object sender, EventArgs e)
        {
            try
            {

                int pilotcount = pilots.Count - 1;
                int crewcount = cabincrew.Count - 1;
                int selectedcount = 0;

                if (lstPersoneel.SelectedIndex >= pilotcount)
                {
                    selectedcount = lstPersoneel.SelectedIndex - pilotcount - 1;
                    cabincrew.RemoveAt(selectedcount);

                }
                else
                {
                    selectedcount = lstPersoneel.SelectedIndex;
                    pilots.RemoveAt(selectedcount);
                }


                AddFullCrew();
                LoadListboxes();

            }
            catch (Exception ee)
            {
                MessageBox.Show("Select a crewmember!");
            }
        }
        #endregion

        #region Add / edit / remove passengers
        private void btnToevoegenPassagier_Click(object sender, EventArgs e)
        {
            frmPassengerManagement PassengerManagement = new frmPassengerManagement();
            if (PassengerManagement.ShowDialog() == DialogResult.OK)
            {
                passengers.Add(PassengerManagement.Passenger);
                LoadListboxes();
            }

        }
        private void btnVerwijderenPassagiers_Click(object sender, EventArgs e)
        {
            try
            {
                passengers.RemoveAt(lstPassagiers.SelectedIndex);
                LoadListboxes();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Select a passenger!");
            }
        }
        private void btnWijzigenPassagier_Click(object sender, EventArgs e)
        {
            try
            {
                frmPassengerManagement PassengerManagement = new frmPassengerManagement(true, passengers[lstPassagiers.SelectedIndex]);
                if (PassengerManagement.ShowDialog() == DialogResult.OK)
                {
                    passengers[lstPassagiers.SelectedIndex] = PassengerManagement.Passenger;
                    LoadListboxes();
                }


            }
            catch (Exception ee)
            {
                MessageBox.Show("Select a passenger!");
            }
        }

        #endregion

        #region Add / edit / remove Airports
        private void btnToevoegenLuchthaven_Click(object sender, EventArgs e)
        {
            frmAirportManagement AirportManagement = new frmAirportManagement();
            if (AirportManagement.ShowDialog() == DialogResult.OK)
            {
                airports.Add(AirportManagement.Airport);
                LoadListboxes();
            }
        }
        private void btnVerwijderLuchthaven_Click(object sender, EventArgs e)
        {

            try
            {
                airports.RemoveAt(lstLuchthaven.SelectedIndex);
                LoadListboxes();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Select an airport!");
            }
        }

        private void btnWijzigenLuchthaven_Click(object sender, EventArgs e)
        {

            try
            {

                frmAirportManagement AirportManagement = new frmAirportManagement(true, airports[lstLuchthaven.SelectedIndex]);
                if (AirportManagement.ShowDialog() == DialogResult.OK)
                {
                    airports[lstLuchthaven.SelectedIndex] = (AirportManagement.Airport);
                    LoadListboxes();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("Select an airport!");
            }

        }
        #endregion

        #region Add / edit / remove Flights
        private void btnToevoegenVlucht_Click(object sender, EventArgs e)
        {
            frmFlightManagement FlightManagement = new frmFlightManagement(airplanes, airports, pilots, cabincrew);
            if (FlightManagement.ShowDialog() == DialogResult.OK)
            {
                Flights.Add(FlightManagement.Flight);
                LoadListboxes();
            }
        }

        private void btnWijzigenVlucht_Click(object sender, EventArgs e)
        {
            try
            {
                frmFlightManagement FlightManagement = new frmFlightManagement(airplanes, airports, pilots, cabincrew, Flights[lstVluchten.SelectedIndex]);
                if (FlightManagement.ShowDialog() == DialogResult.OK)
                {
                    Flights[lstVluchten.SelectedIndex] = (FlightManagement.Flight);
                    LoadListboxes();
                }
            }
            catch (Exception ee)
            {

                MessageBox.Show("Selecteer een vlucht!");
            }
        }

        private void btnVerwijderVlucht_Click(object sender, EventArgs e)
        {
            try
            {
                Flights.RemoveAt(lstVluchten.SelectedIndex);
                LoadListboxes();
            }
            catch (Exception ee)
            {

                MessageBox.Show("Selecteer een vlucht!");
            }
        }
        #endregion
        #region Add Reservations
        private void btnReservatieMaken_Click(object sender, EventArgs e)
        {
            try
            {
                frmReservationManagement ReservationManagement = new frmReservationManagement(passengers, Flights[lstVluchten.SelectedIndex]);
                if (ReservationManagement.ShowDialog() == DialogResult.OK)
                {
                    Flights[lstVluchten.SelectedIndex] = ReservationManagement.Flight;
                    UpdatePassengerList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selecteer een vlucht!");

            }
        }
        private void lstVluchten_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePassengerList();
        }
        private void UpdatePassengerList()
        {
            lstPassagiersVanVlucht.Items.Clear();
            try
            {
                foreach (Passenger pass in Flights[lstVluchten.SelectedIndex].Reservations)
                {
                    lstPassagiersVanVlucht.Items.Add(pass.ToString());
                }
            }
            catch (Exception)
            {
                lstPassagiersVanVlucht.Items.Add("Nog geen passagiers op deze vlucht!");

            }
        }
   
        #endregion

      
    }



}
