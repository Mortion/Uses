using System;
using System.Collections.Generic;
using System.ComponentModel;
using BeertjesLibrary;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beertjeswinkel
{
    public partial class frmBeertjeToevoegen : Form
    {
        public frmBeertjeToevoegen()
        {
            InitializeComponent();
            isPlushe = true;
        }

        private Bitmap Afbeelding = null;

        public Beertje beertje { get; set; }
        

      

        public bool isPlushe { get; set; }


        private void btnZoekAfbeelding_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter =
        "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" +
        "All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Afbeelding = new Bitmap(ofd.FileName);
                    txtAfbeeldingPath.Text = ofd.FileName;
                    picAfbeeldingBeertje.Image = Afbeelding;
                }
                catch (BadImageFormatException bfm)
                {
                    MessageBox.Show("Geen juiste image format");
                }


            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
         
            if (frmBeertjeswinkel.wijzigen == false)
            {
                if (isPlushe == false)
                {
                    beertje = new ElektronischBeertje(txtNaam.Text, Afbeelding, (int)nmAantalBatterijen.Value);
                }
                else
                {
                    beertje = new PlusheBeertje(txtNaam.Text, Afbeelding, txtWasprogramma.Text);
                }
            }
            else
            {
                
            }



        }

        private void PlusheOfElektrisch(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Name == "rbPlushe")
            {
                isPlushe = true;
                txtWasprogramma.Visible = true;
                lblExtra.Text = "Wasprogramma";
                nmAantalBatterijen.Visible = false;
            }
            else
            {
                isPlushe = false;
                txtWasprogramma.Visible = false;
                lblExtra.Text = "Aantal batterijen";
                nmAantalBatterijen.Visible = true;
            }

        }

        private void frmBeertjeToevoegen_FormClosing(object sender, FormClosingEventArgs e)
        {

            frmBeertjeswinkel.wijzigen = false;
        }
        frmBeertjeswinkel frmBeertjeswinkel = new frmBeertjeswinkel();
        private void frmBeertjeToevoegen_Load(object sender, EventArgs e)
        {

            if (frmBeertjeswinkel.wijzigen == true)
            {
             
            }
          
        }
    }
}
