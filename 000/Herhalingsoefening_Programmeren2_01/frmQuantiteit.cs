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
    public partial class frmQuantiteit : Form
    {
        public frmQuantiteit()
        {
            InitializeComponent();


        }

        private int aantal;
        
        public int Aantal
        {
            get { return (int) nmAantalProduct.Value; }
            set { aantal = value; }
        }


    }
}
