using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herhalingsoefening_Programmeren2_01
{
    public partial class frmWinkelmandje : Form
    {




        private  List<Product> producten = new List<Product>();
        private  List<Artikel> artikels = new List<Artikel>();

        private frmProductDetail frmProductDetail;
        private frmQuantiteit frmQuantiteit;

        private string path = System.AppDomain.CurrentDomain.BaseDirectory.Substring(0, System.AppDomain.CurrentDomain.BaseDirectory.Length - 10);


        private static int selectedIndexProducten = 0;
       
        public frmWinkelmandje()
        {
            InitializeComponent();
           

        }

        private void btnToevoegenProduct_Click(object sender, EventArgs e)
        {
            frmProductDetail = new frmProductDetail();
            if (frmProductDetail.ShowDialog() == DialogResult.OK)
            {
                Product p = frmProductDetail.product;

                producten.Add(p);

                toonProducten();

            }

        }

        public void toonProducten()
        {
            lstProducten.Items.Clear();

            foreach (Product p in producten)
            {
                lstProducten.Items.Add(p.ToString());
            }
        }
        private void initProducten()
        {

            producten.Clear();
            //TODO
            StreamReader file = new StreamReader(path + "producten.txt");
            string lijn;
            while ((lijn = file.ReadLine()) != null)
            {
                string[] appart = lijn.Split('|');

               
                    Product pr = new Product();
                    pr.Code = Convert.ToInt32(appart[0]);
                    pr.Naam = appart[1];
                    pr.Prijs = Convert.ToDouble( appart[2]);
                    producten.Add(pr);
                
            }

            file.Close();
            

        }



        private void toonLijst(object sender, EventArgs e)
        {
            toonProducten();
            toonArtikels();
        }

        private void toonArtikels()
        {
            lstWinkelmand.Items.Clear();

            foreach (Artikel a in artikels)
            {
                lstWinkelmand.Items.Add(a.ToString());
            }

        }


        private void indexProducten(object sender, EventArgs e)
        {
            ListBox lst = (ListBox)sender;

            selectedIndexProducten = lst.SelectedIndex;


        }

        private void btnVerwijderenProduct_Click(object sender, EventArgs e)
        {
            producten.RemoveAt(lstProducten.SelectedIndex);
            toonProducten();
        }

        private void btnWegschrijvenProduct_Click(object sender, EventArgs e)
        {
            

        

        }

        private void wegschrijvenProducten()
        {
            StreamWriter file = new StreamWriter(path + "producten.txt");

            foreach (Product pr in producten)
            {
                file.WriteLine(pr.Code + "|" + pr.Naam + "|" + pr.Prijs);
            }
            file.Close();
        }

        private void frmWinkelmandje_FormClosed(object sender, FormClosedEventArgs e)
        {
            wegschrijvenProducten();
        }

        private void btnLeegmakenMandje_Click(object sender, EventArgs e)
        {
            lstWinkelmand.Items.Clear();
            artikels.Clear();
        }

        private void btnToevoegenMandje_Click(object sender, EventArgs e)
        {
            frmQuantiteit = new frmQuantiteit();
           if( frmQuantiteit.ShowDialog() == DialogResult.OK)
            {
                Artikel a = new Artikel(producten[selectedIndexProducten],frmQuantiteit.Aantal);
                artikels.Add(a);
                toonArtikels();
         }


        }

        private void lstWinkelmand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBerekenFactuur_Click(object sender, EventArgs e)
        {
            double factuurTotaal = 0;

            lstFactuur.Items.Clear();

            lstFactuur.Items.Add("Volgende artikels heeft u aangeschaft");
            lstFactuur.Items.Add("________________");

            foreach (Artikel a in artikels)
            {
                lstFactuur.Items.Add("");
                lstFactuur.Items.Add(a.factuurtekstWeergeven());
                factuurTotaal += a.berekenSubtotaal();

            }
            lstFactuur.Items.Add("");
            lstFactuur.Items.Add("Het totaalbedrag is: € " + factuurTotaal);


        }

        private void frmWinkelmandje_Load(object sender, EventArgs e)
        {
            initProducten();
        }

        private void btnVerwijderenMandje_Click(object sender, EventArgs e)
        {
            try
            {
 artikels.RemoveAt(lstWinkelmand.SelectedIndex);
            }
            catch (ArgumentOutOfRangeException aeoo)
            {
                MessageBox.Show("Selecteer een artikel");
            }
           



            toonArtikels();
        }


    }
}
