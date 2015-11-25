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
    public partial class frmQuantity : Form
    {
        public int aantal {get;set;}
        
        public frmQuantity()
        {
            InitializeComponent();
        }

        private void btnAankopen_Click(object sender, EventArgs e)
        {
            this.aantal = Convert.ToInt16(numUD.Value);
        }

        public Artikel Artikel
        {
            get
            {
                Artikel tmp = new Artikel(Convert.ToInt16(numUD.Value));
                return tmp;
            }
        }
    }
}
