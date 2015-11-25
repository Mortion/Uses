using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObjects;

namespace EasyShopApp
{
    public partial class frmMaakGebruiker : Form
    {
        public frmMaakGebruiker()
        {
            InitializeComponent();
        }

        private Gebruiker _gebruiker = new Gebruiker();
        private void btnGebruikerToevoegen_Click(object sender, EventArgs e)
        {
            _gebruiker.Gebruikersnaam = txtGebruikersnaam.Text;

            if (_gebruiker.SetPassword(txtPasswoord.Text, txtPaswoordherhaling.Text))
            {
                MessageBox.Show("Gebruiker aangemaakt");
            }
            else
            {
                MessageBox.Show("Fout passwoord");
            }

        }

        private void VoegGebruikerToeAanDb()
        {
            //TODO: dbconnet
        }
    }
}
