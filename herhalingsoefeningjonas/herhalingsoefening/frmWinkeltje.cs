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
            try
            {
                StreamWriter file = new StreamWriter(@"producten.txt");
                foreach (var lijn in producten)
                {
                    file.WriteLine(lijn.ToString());
                }           
                file.Close();
                MessageBox.Show("wegschrijven is gelukt!");
            }
            catch { MessageBox.Show("wegschrijven is mislukt"); };
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
                producten.Clear();
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
                DialogResult dialogResult = MessageBox.Show("Bent  zeker dat u dit product wenst te verwijderen uit de lijst producten", "Vraag", MessageBoxButtons.YesNo);
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
                Artikel a = new Artikel();
                
               
                    lstRechts.Items.Add(lstLinks.SelectedItem);
                      
            }
        }

        private void btnLinks_Click(object sender, EventArgs e)
        {
            lstRechts.Items.Remove(lstRechts.SelectedItem);
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            frmQuantity frm3 = new frmQuantity();
            lblHidden.Text = frm3.Artikel.FactuurtekstWeergeven();
            lblHidden2.Text = frm3.Artikel.ToString();
        }
    }
}

