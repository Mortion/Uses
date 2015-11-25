using ProductLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToonProducten_01
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private List<Product> producten = new List<Product>();

        private void MainForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                Product product = new Product(i,Math.Pow(i,2));
                //product.Code = i;
                //product.Prijs = Math.Pow(i, 2);
                producten.Add(product);

            }

            for (int i = 0; i < 3; i++)
            {
                Auto auto = new Auto(4,"Grijs");
               auto.Code = i;
                auto.Prijs = Math.Pow(i, 2);
                producten.Add(auto);

            }


            foreach (Product p in producten)
            {
                lstProducten.Items.Add(p.ToonDetails());
            }

        }
    }
}
