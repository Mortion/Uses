using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetConnCheck
{
    public partial class Form1 : Form
    {
        [DllImport("wininet.dll")] private static extern bool InternetGetConnectionState(out int descr, int value);


        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
         Checkcon();
        }

        bool bb = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();

        private void Checkcon()
        {
            MessageBox.Show(bb == true ? "Internet connections are available" : "Internet connections are not available");
        }
    }
}
