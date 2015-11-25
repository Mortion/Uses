using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyShopApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnNieuweGebruiker_Click(object sender, EventArgs e)
        {
            frmMaakGebruiker MaakGebruiker= new frmMaakGebruiker();
            if (MaakGebruiker.ShowDialog() == DialogResult.OK)
            {
                
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //TODO: dbCheckLogin
            //if true
            


        }
    }
}
