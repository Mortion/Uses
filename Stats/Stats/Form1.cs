using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stats
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ints.Add(20);
            ints.Add(40);
            ints.Add(60);
            ints.Add(80);
            ints.Add(55);
            ints.Add(33);
            ints.Add(41);

            panel1.Invalidate();
            panel1.BorderStyle = BorderStyle.Fixed3D;

        }
        List<int> ints = new List<int>();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            int pWidth = panel1.Width;
            int pHeight = panel1.Height;

            int graphLengthX = pWidth - 20;
            int graphWidthY = pHeight - 20;

            int interval = 10;
            int max = 100;
            int intY = max / interval;


            int spaceX = (graphLengthX - 5) / ints.Count;
            int spaceY = (graphWidthY - 5) / interval;

            Graphics g = panel1.CreateGraphics();


            //x-as
            Point p1 = new Point((10), graphWidthY);
            Point p2 = new Point(graphLengthX, graphWidthY);
            g.DrawLine(new Pen(Color.Black), p1, p2);

            //y-as
            p1 = new Point((20), 10);
            p2 = new Point((20), graphWidthY + 10);
            g.DrawLine(new Pen(Color.Black), p1, p2);


            //onderverdeling x-as
            for (int i = 0; i < ints.Count; i++)
            {
                p1 = new Point((20 + spaceX * i), graphWidthY - 10);
                p2 = new Point((20 + spaceX * i), graphWidthY + 10);
                g.DrawLine(new Pen(Color.Black), p1, p2);
            }

            //onderverdeling y-as
            for (int i = 0; i < intY; i++)
            {
                p1 = new Point((10), graphWidthY - spaceY * i);
                p2 = new Point((30), graphWidthY - spaceY * i);
                g.DrawLine(new Pen(Color.Black), p1, p2);
            }

            //drawRect waarden

            foreach (var w in ints)
            {
                //  Rectangle r = new Rectangle(new Point(20,graphWidthY+10),new Size(spaceX, (max / w)) );
                Rectangle r = new Rectangle(new Point(20, graphWidthY - (max/w)), new Size(spaceX, graphWidthY - (max / w)));
                g.FillRectangle(new SolidBrush(Color.DarkRed),r );
            }



        }
    }
}
