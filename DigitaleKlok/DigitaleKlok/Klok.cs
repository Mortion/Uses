using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace DigitaleKlok
{
    public partial class ucDigitaleKlok : UserControl
    {
        public ucDigitaleKlok()
        {
            InitializeComponent();
            tmrTijdKlok.Start();

        }


        private DateTime DigitaleTijd;
        int milli = 0;
        private void tmrTijdKlok_Tick(object sender, EventArgs e)
        {
            string tijd = DateTime.Now.ToString("HH:mm:ss:f",
                                             CultureInfo.InvariantCulture); 
           // lblKlokDisplay.Text = DateTime.Now.ToString("h:mm:ss tt");

            lblKlokDisplay.Text = tijd;
        }

        private void lblKlokDisplay_Click(object sender, EventArgs e)
        {

        }
    }
}
