using BankrekeningLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankjeSpelen
{
    public partial class frmMain : Form
    {

        /// <summary>
        ///     Gemaakt door: Jarrik Van Camp
        ///     Klas: 12675
        /// </summary>

        #region Properties

        ///<summary>
        ///Initiatie van je bankrekening
        /// </summary>
        private Bankrekening Bankrekening;

        #endregion

        /// <summary>
        /// Constructor van je MainForm
        /// </summary>
        public frmMain()
        {
            InitializeComponent();

        }
        /// <summary>
        /// Handling van je BankrekeningInHetRoodEventArgs klasse
        /// </summary>
        /// <param name="sender">Het object waarin de EventHandling gebeurd</param>
        /// <param name="e">Een parameter waar je meer info uit de BankrekeningInHetRoodEventArgs klasse kunt halen </param>
        private void Bankrekening_InHetRood(object sender, BankrekeningInHetRoodEventArgs e)
        {

            MessageBox.Show("Uw rekening staat in het rood: (" + e.Percentage.ToString("P1", CultureInfo.CurrentCulture) + ")");


        }

        private void Bankerekening_OverHetRood(object sender, BankrekeningOverHetRoodEventArgs e)
        {
            MessageBox.Show("Uw Saldo is te laag om de overschrijving uit te voeren (Saldo: " + Bankrekening.Saldo + ")");

        }

        /// <summary>
        /// Hier maak je uw rekening aan en leg je een link naar je BankrekeningInHetRoodEventArgs klasse
        /// </summary>
        private void btnRekeningAanmaken_Click(object sender, EventArgs e)
        {
            Double Saldo = 0;
            int Dieptepunt = 0;

            if (Double.TryParse(txtSaldo.Text, out Saldo))
            {
                if (int.TryParse(txtDieptepunt.Text, out Dieptepunt))
                {
                    Bankrekening = new Bankrekening(Dieptepunt, Saldo);
                    MessageBox.Show("Rekening aangemaakt");
                    grpOverschrijvingen.Enabled = true;
                    Bankrekening.BankrekeningInHetRood += new EventHandler<BankrekeningInHetRoodEventArgs>(Bankrekening_InHetRood);
                    Bankrekening.BankrekeningOverHetRood += new EventHandler<BankrekeningOverHetRoodEventArgs>(Bankerekening_OverHetRood);
                }
                else
                {
                    MessageBox.Show("Geen nummer ingegeven in de Dieptepunt TextBox");
                }
            }
            else
            {
                MessageBox.Show("Geen nummer ingegeven in de Saldo TextBox");
            }

        }


        /// <summary>
        /// Hier gebeurt de overschrijving
        /// </summary>
        private void btnOverschrijving_Click(object sender, EventArgs e)
        {
            Double Overschrijving = 0;
            if (Double.TryParse(txtOverschrijving.Text, out Overschrijving))
            {
                Bankrekening.Overschrijving(Overschrijving);
                //MessageBox.Show("Uw huidig saldo is: " + Bankrekening.Saldo, "Uw Saldo");
            }
        }
        /// <summary>
        ///	Bij	het	sluiten	van	het	formulier	dienen	we	de	event	te	ontkoppelen	van	de	methode
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Bankrekening.BankrekeningInHetRood -= Bankrekening_InHetRood;
        }
    }
}
