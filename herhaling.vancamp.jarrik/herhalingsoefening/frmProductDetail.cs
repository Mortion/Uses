using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace herhalingsoefening
{
    public partial class frmProductDetail : Form
    {
        public frmProductDetail()
        {
            InitializeComponent();
        }

        public Product Product
        {
            get 
            {
                Product tmp = new Product(txtCode.Text,txtNaam.Text,decimal.Parse(txtPrijs.Text));
                return tmp;
            }
        }
        #region buttons
        private void btnBewaar_Click(object sender, EventArgs e)
        {
        }

        private void btnAnnuleer_Click(object sender, EventArgs e)
        {
        }
        #endregion

        private void frmProductDetail_Load(object sender, EventArgs e)
        {
        }
    }
}
