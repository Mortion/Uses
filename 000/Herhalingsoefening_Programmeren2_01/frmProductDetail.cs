using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herhalingsoefening_Programmeren2_01
{
    public partial class frmProductDetail : Form
    {
        public frmProductDetail()
        {
            InitializeComponent();
        }

      

        private void btnAnnuleer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Product product
        {
            get
            {
                Product p = new Product();
                p.Code = int.Parse(txtCodeProduct.Text);
                p.Naam = txtNaamProduct.Text;
                p.Prijs = Double.Parse(txtPrijsProduct.Text);

                return p;
            }
            set
            {
                product = value;

            }
        }


        private void btnBewaar_Click(object sender, EventArgs e)
        {
         

        }
    }
}
