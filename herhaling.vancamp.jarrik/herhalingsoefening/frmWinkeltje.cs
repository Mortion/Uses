using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace herhalingsoefening
{
    public partial class frmWinkeltje : Form
    {
        public List<Product> producten = new List<Product>();
        public List<Artikel> artikelen = new List<Artikel>();

        private string path = System.AppDomain.CurrentDomain.BaseDirectory.Substring(0, System.AppDomain.CurrentDomain.BaseDirectory.Length - 10);


        decimal prijs = 0;

        public frmWinkeltje()
        {
            InitializeComponent();
            lblHidden.Text = string.Empty; 
            lblHidden2.Text = string.Empty;
        }

        private void btnSluiten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnWegschrijven_Click(object sender, EventArgs e)
        {
            WegschrijvenProducten();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            try
            {
                lstLinks.Items.Clear();
                frmProductDetail frm2 = new frmProductDetail();
                if (frm2.ShowDialog() == DialogResult.OK)
                {
                    producten.Add(frm2.Product);
                    ProductWeergeven();
                }
                else
                {
                }
            }
            catch
            {
                MessageBox.Show("Input is niet correct, probeer opnieuw!");
            }
        }

        private void ProductWeergeven()
        {
            lstLinks.Items.Clear();
            foreach(Product Item in producten)
            {
                lstLinks.Items.Add(Item);
            }
        }

        private void btnLeeg_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Wilt U het mandje leegmaken?", "Mandje leegmaken", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                artikelen.Clear();
                lstRechts.Items.Clear();
                lblHidden.Text = string.Empty;
                lblHidden2.Text = string.Empty;
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            if (lstLinks.SelectedIndex == -1)
            {
                MessageBox.Show("Selecteer eerst een item!");
            }
            else
            {
                int var1 = lstLinks.SelectedIndex;
                DialogResult dialogResult = MessageBox.Show("Bent  zeker dat u " +
                    producten[var1].Naam +" wenst te verwijderen uit de lijst producten", "Vraag", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    producten.RemoveAt(lstLinks.SelectedIndex);
                    ProductWeergeven();
                }
                else if (dialogResult == DialogResult.No)
                {
                }
            }        
        }

        private void btnRechts_Click(object sender, EventArgs e)
        {
            frmQuantity frm3 = new frmQuantity();
            if (frm3.ShowDialog() == DialogResult.OK)
            {
                Artikel art1 = new Artikel(frm3.aantal);
                int var1 = lstLinks.SelectedIndex;
                art1.Code = producten[var1].Code;
                art1.Naam = producten[var1].Naam;
                art1.Prijs = producten[var1].Prijs;
               
                
                artikelen.Add(art1);
                ArtikelsWeergeven();

            }
        }

        private void ArtikelsWeergeven()
        {
            lstRechts.Items.Clear();
            foreach (Artikel Item in artikelen)
            {
                lstRechts.Items.Add(Item);
            }
        }

        private void btnLinks_Click(object sender, EventArgs e)
        {
            lstRechts.Items.Remove(lstRechts.SelectedItem);
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            prijs = 0;
            lblHidden2.Text = "";
            lblHidden.Text = "Volgende artikelen heeft u aangeschaft" + Environment.NewLine + "_______________________________";
            foreach(Artikel test in artikelen)
            {
               prijs += test.BerekenSubTotaal();
               lblHidden2.Text += Environment.NewLine+ test.FactuurtekstWeergeven();
            }
            lblHidden2.Text += Environment.NewLine + "Het totaalbedrag is : " + prijs.ToString("C2");
        }


        private void WegschrijvenProducten()
        {
            StreamWriter file = new StreamWriter(path + "producten.txt");

            foreach (Product pr in producten)
            {
                file.WriteLine(pr.Code + "|" + pr.Naam + "|" + pr.Prijs);
            }
            file.Close();
        }

        private void frmWinkeltje_Load(object sender, EventArgs e)
        {
            InitProducten();
            ProductWeergeven();
        }

        private void InitProducten()
        {

            producten.Clear();
            //TODO
            StreamReader file = new StreamReader(path + "producten.txt");
            string lijn;
            while ((lijn = file.ReadLine()) != null)
            {
                string[] appart = lijn.Split('|');


                Product pr = new Product();
                pr.Code = Convert.ToString(appart[0]);
                pr.Naam = appart[1];
                pr.Prijs = Convert.ToDecimal(appart[2]);
                producten.Add(pr);

            }

            file.Close();


        }
    }
}

