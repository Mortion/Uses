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
    public partial class frmAirportManagement : Form
    {
        public frmAirportManagement()
        {
            InitializeComponent();
        }
        public frmAirportManagement(bool isEdit, Airport airport)
        {
            InitializeComponent();
            this.Airport = airport;
            txtLocation.Text = Airport.Location;
            txtAirportName.Text = Airport.Name;
        }
        public Airport Airport { get; set; }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            this.Airport = new Airport(txtLocation.Text,txtAirportName.Text);

        }
    }
}
