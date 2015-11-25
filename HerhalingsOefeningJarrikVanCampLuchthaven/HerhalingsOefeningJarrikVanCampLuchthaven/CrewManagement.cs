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
    public partial class frmCrewManagement : Form
    {
        public frmCrewManagement(List<Airplane> airplanes)
        {
            InitializeComponent();
            
            foreach (Airplane plane in airplanes)
            {
                lstCertificats.Items.Add(plane.ToString());
            }
            this.Airplanes = airplanes;
            isEdit = false;
            udcCrewData.Birthdate = DateTime.Now;
        }

       

        public frmCrewManagement(List<Airplane> airplanes, bool isEdit, Person person)
        {
            InitializeComponent();

            foreach (Airplane plane in airplanes)
            {
                lstCertificats.Items.Add(plane.ToString());
            }
            this.Airplanes = airplanes;
            this.isEdit = isEdit;

            CrewOrPilot = person;

            udcCrewData.txtFirstname.Text = CrewOrPilot.Firstname;
            udcCrewData.txtLastname.Text = CrewOrPilot.Name;

            
            udcCrewData.dtBirthdate.Value = CrewOrPilot.Birthdate;

            if(CrewOrPilot.Gender == Gender.Female)
            {
                udcCrewData.rbFemaleGender.Checked = true;
                udcCrewData.rbMaleGender.Checked = false;
            }
            else
            {
                udcCrewData.rbFemaleGender.Checked = false;
                udcCrewData.rbMaleGender.Checked = true;
            }

            if(CrewOrPilot is Cabinecrew)
            {
                rbCrew.Checked = true;
            }


        }


        public List<Airplane> Airplanes { get; set; }
        public Person CrewOrPilot { get; set; }
        public bool isPilot = true;
        public bool isEdit = false;
        private void btnAdd_Click(object sender, EventArgs e)
        {
          
                if (isPilot == true)
                {
                    

                    CrewOrPilot = new Pilot(udcCrewData.Birthdate, udcCrewData.Firstname, udcCrewData.Lastname, udcCrewData.GenderUser);

                    foreach (int plane in lstCertificats.SelectedIndices)
                    {
                        ((Pilot)CrewOrPilot).AddAirplaneTypeLicense(Airplanes[plane]);
                    }

                }
                else
                {
                    CrewOrPilot = new Cabinecrew(udcCrewData.Birthdate, udcCrewData.Firstname, udcCrewData.Lastname, udcCrewData.GenderUser);
                }
          

           
        }

        private void rbPilot_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPilot.Checked == true)
            {
                isPilot = true;
                lblCertificat.Visible = true;
                lstCertificats.Visible = true;
            }
            else
            {
                isPilot = false;
                lblCertificat.Visible = false;
                lstCertificats.Visible = false;
            }
        }
    }
}
