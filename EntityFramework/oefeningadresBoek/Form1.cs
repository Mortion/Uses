using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oefeningadresBoek
{
    public partial class Form1 : Form
    {
        private AdresService service = new AdresService();

        public Form1()
        {
            InitializeComponent();
            LoadAdressen();
        }

        private void LoadAdressen()
        {
            lsbAdresssen.DataSource = null;
            lsbAdresssen.DataSource = service.GetAll();
            lsbAdresssen.DisplayMember = "Naam";
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            AdresGegeven adres = new AdresGegeven();
            adres.Adres = txtAdres.Text;
            adres.Email = txtEmail.Text;
            adres.Gsm = txtGsm.Text;
            adres.Naam = txtNaam.Text;

            service.AdresOpslaan(adres);
            LoadAdressen();
        }

        private void btnOphalen_Click(object sender, EventArgs e)
        {

        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            if (lsbAdresssen.SelectedItem != null)
            {
                AdresGegeven adres = (AdresGegeven)lsbAdresssen.SelectedItem;
                service.AdresVerwijderen(adres.Id);
                MessageBox.Show("Adres verwijderd!");
                LoadAdressen();
            }
        }

        private void lsbAdresssen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbAdresssen.SelectedItem != null)
            {
                AdresGegeven adres = (AdresGegeven)lsbAdresssen.SelectedItem;
                txtAdres.Text = adres.Adres;
                txtEmail.Text = adres.Email;
                txtGsm.Text = adres.Gsm;
                txtNaam.Text = adres.Naam;
                lblID.Text = adres.Id.ToString();
            }
            btnNieuw.Visible = true;
        }
    }
}
