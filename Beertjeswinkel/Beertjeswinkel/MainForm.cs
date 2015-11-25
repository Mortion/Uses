using BeertjesLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beertjeswinkel
{
    public partial class frmBeertjeswinkel : Form
    {
        public frmBeertjeswinkel()
        {
            InitializeComponent();

        }

        List<Beertje> beertjes = new List<Beertje>();

        private void btnToevoegen_Click(object sender, EventArgs e)
        {

            frmBeertjeToevoegen frmBeertjeToevoegen = new frmBeertjeToevoegen();
            //  frmBeertjeToevoegen.ShowDialog();

            if (frmBeertjeToevoegen.ShowDialog() == DialogResult.OK)
            {
                beertjes.Add(frmBeertjeToevoegen.beertje);
                ToonBeertjeslijst();
            }



        }

        private void ToonBeertjeslijst()
        {
            lstBeertjes.Items.Clear();
            lstBeertjes.Items.Add("Beertjes Lijst");
            lstBeertjes.Items.Add("______________");

            foreach (Beertje beertje in beertjes)
            {
                if (beertje is PlusheBeertje)
                {
                    lstBeertjes.Items.Add(((PlusheBeertje)beertje).ToString());
                }
                else if (beertje is ElektronischBeertje)
                {
                    lstBeertjes.Items.Add(((ElektronischBeertje)beertje).ToString());
                }
            }

        }
        private int selectedIndex = 0;
        private void lstBeertjes_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex = lstBeertjes.SelectedIndex - 2;

            try
            {
                picBeertjesportret.Image = new Bitmap(beertjes[selectedIndex].Afbeelding);
            }
            catch (ArgumentOutOfRangeException ioor)
            {
                picBeertjesportret.Image = null;
            }

        }

        public bool wijzigen { get; set; }

        private void btnWijzigen_Click(object sender, EventArgs e)
        {

            wijzigen = true;
            frmBeertjeToevoegen frmBeertjeToevoegen = new frmBeertjeToevoegen();
            //  frmBeertjeToevoegen.ShowDialog();

            if (frmBeertjeToevoegen.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void frmBeertjeswinkel_Load(object sender, EventArgs e)
        {
            wijzigen = false;
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            try
            {
                beertjes.RemoveAt(lstBeertjes.SelectedIndex-2);
            }
            catch (IndexOutOfRangeException op)
            {

            }

        }

    }
}
