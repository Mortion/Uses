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
    public partial class frmPassengerManagement : Form
    {
        public frmPassengerManagement()
        {
            InitializeComponent();

        }
        public frmPassengerManagement(bool isEdit, Passenger passenger):base()
        {
       
            this.Passenger = passenger;

            udcPassengerData.txtFirstname.Text = this.Passenger.Firstname;
            udcPassengerData.txtLastname.Text = this.Passenger.Name;


            udcPassengerData.dtBirthdate.Value = this.Passenger.Birthdate;

            if (this.Passenger.Gender == Gender.Female)
            {
                udcPassengerData.rbFemaleGender.Checked = true;
                udcPassengerData.rbMaleGender.Checked = false;
            }
            else
            {
                udcPassengerData.rbFemaleGender.Checked = false;
                udcPassengerData.rbMaleGender.Checked = true;
            }

        }

        public Passenger Passenger { get; set; }

        private void btnAdd_Click(object sender, EventArgs e)
        {


                this.Passenger = new Passenger(udcPassengerData.Birthdate, udcPassengerData.Firstname, udcPassengerData.Lastname, udcPassengerData.GenderUser);

               
            
        }
    }
}
