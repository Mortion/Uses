using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitaleKlok
{
    public partial class DigitaleKlokPainter : UserControl
    {
        private Rectangle Top, Bot, LinksTop, RechtsTop, LinksBot, RechtsBot, Mid;
        private List<Rectangle> nul, een, twee, drie, vier, vijf, zes, zeven, acht, negen;

        private void tmrStartMilliseconden_Tick_1(object sender, EventArgs e)
        {
            drawMilliseconden();
        }

        private void tmrStartSeconden_Tick(object sender, EventArgs e)
        {
            drawTimeSeconde();
            tmrStartSeconden.Interval = 1000;
        }

        private void tmrStartMinuten_Tick_1(object sender, EventArgs e)
        {
            drawMinuten();
            tmrStartMinuten.Interval = 60000;
        }

        private void tmrStartUur_Tick(object sender, EventArgs e)
        {
            drawUur();
            tmrStartUur.Interval = 60000;
        }

        private List<List<Rectangle>> Getallen;




        string time = "000000";

        public DigitaleKlokPainter()
        {
            InitializeComponent();

            /// <summary>
            /// Het display template maken.
            /// </summary>

            Top = new Rectangle(25, 5, 90, 10);// top  
            LinksTop = new Rectangle(10, 20, 10, 85);//links top
            LinksBot = new Rectangle(10, 125, 10, 85);//links bot
            Bot = new Rectangle(25, 215, 90, 10);// bot  
            RechtsTop = new Rectangle(120, 20, 10, 85);//rechts top
            RechtsBot = new Rectangle(120, 125, 10, 85);//rechts bot
            Mid = new Rectangle(25, 110, 90, 10);// mid  

            /// <summary>
            ///  het getal aanmaken;
            /// </summary>

            Getallen = new List<List<Rectangle>>();

            nul = new List<Rectangle>();
            nul.Add(Top);
            nul.Add(LinksTop);
            nul.Add(RechtsTop);
            nul.Add(Bot);
            nul.Add(LinksBot);
            nul.Add(RechtsBot);
            Getallen.Add(nul);

            een = new List<Rectangle>();
            een.Add(RechtsTop);
            een.Add(RechtsBot);
            Getallen.Add(een);

            twee = new List<Rectangle>();
            twee.Add(Top);
            twee.Add(RechtsTop);
            twee.Add(Bot);
            twee.Add(LinksBot);
            twee.Add(Mid);
            Getallen.Add(twee);


            drie = new List<Rectangle>();
            drie.Add(Top);
            drie.Add(RechtsTop);
            drie.Add(Bot);
            drie.Add(RechtsBot);
            drie.Add(Mid);
            Getallen.Add(drie);


            vier = new List<Rectangle>();
            vier.Add(LinksTop);
            vier.Add(RechtsTop);
            vier.Add(RechtsBot);
            vier.Add(Mid);
            Getallen.Add(vier);

            vijf = new List<Rectangle>();
            vijf.Add(Top);
            vijf.Add(LinksTop);
            vijf.Add(Bot);
            vijf.Add(RechtsBot);
            vijf.Add(Mid);
            Getallen.Add(vijf);


            zes = new List<Rectangle>();
            zes.Add(Top);
            zes.Add(LinksTop);
            zes.Add(Bot);
            zes.Add(LinksBot);
            zes.Add(RechtsBot);
            zes.Add(Mid);
            Getallen.Add(zes);


            zeven = new List<Rectangle>();
            zeven.Add(Top);
            zeven.Add(RechtsTop);
            zeven.Add(RechtsBot);
            Getallen.Add(zeven);


            acht = new List<Rectangle>();
            acht.Add(Top);
            acht.Add(LinksTop);
            acht.Add(RechtsTop);
            acht.Add(Bot);
            acht.Add(Mid);
            acht.Add(LinksBot);
            acht.Add(RechtsBot);
            Getallen.Add(acht);

            negen = new List<Rectangle>();
            negen.Add(Top);
            negen.Add(LinksTop);
            negen.Add(RechtsTop);
            negen.Add(Bot);
            negen.Add(RechtsBot);
            negen.Add(Mid);
            Getallen.Add(negen);


            tmrStartSeconden.Start();
            tmrStartMilliseconden.Start();
            tmrStartMinuten.Start();
            tmrStartUur.Start();

        }


        private void DigitaleKlokPainter_Load(object sender, EventArgs e)
        {

        }


        private void drawUur()
        {
            Graphics picGraphicsFull = picUurLinks.CreateGraphics();
            picGraphicsFull.Clear(picUurLinks.BackColor);
            picGraphicsFull = picUurRechts.CreateGraphics();
            picGraphicsFull.Clear(picUurRechts.BackColor);


            #region Minuten


            Pen pen = new Pen(Color.Red);
            SolidBrush brush = new SolidBrush(Color.Red);

            tijd = DateTime.Now;


            string uurEerste, uurTweede;

            #region uurTweede

            if (tijd.Hour.ToString().ToCharArray().Length == 1)
            {
                uurTweede = tijd.Hour.ToString().Substring(0);
            }
            else
            {
                uurTweede = tijd.Hour.ToString().Substring(1, 1);
            }


            switch (uurTweede)
            {

                case "0":
                    foreach (Rectangle rect in nul)
                    {


                        Graphics picGraphics = picUurRechts.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;

                case "1":
                    foreach (Rectangle rect in een)
                    {

                        Graphics picGraphics = picUurRechts.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "2":
                    foreach (Rectangle rect in twee)
                    {

                        Graphics picGraphics = picUurRechts.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "3":
                    foreach (Rectangle rect in drie)
                    {

                        Graphics picGraphics = picUurRechts.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "4":
                    foreach (Rectangle rect in vier)
                    {

                        Graphics picGraphics = picUurRechts.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "5":
                    foreach (Rectangle rect in vijf)
                    {

                        Graphics picGraphics = picUurRechts.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "6":
                    foreach (Rectangle rect in zes)
                    {

                        Graphics picGraphics = picUurRechts.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "7":
                    foreach (Rectangle rect in zeven)
                    {

                        Graphics picGraphics = picUurRechts.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "8":
                    foreach (Rectangle rect in acht)
                    {

                        Graphics picGraphics = picUurRechts.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "9":
                    foreach (Rectangle rect in negen)
                    {

                        Graphics picGraphics = picUurRechts.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
            }

            #endregion



            #region uurEerste
            

            if (tijd.Hour.ToString().ToCharArray().Length == 1)
            {
                uurEerste = "0";
            }
            else
            {
                uurEerste = tijd.Hour.ToString().Substring(0, 1);
            }


            switch (uurEerste)
            {

                case "0":
                    foreach (Rectangle rect in nul)
                    {


                        Graphics picGraphics = picUurLinks.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;

                case "1":
                    foreach (Rectangle rect in een)
                    {

                        Graphics picGraphics = picUurLinks.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "2":
                    foreach (Rectangle rect in twee)
                    {

                        Graphics picGraphics = picUurLinks.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "3":
                    foreach (Rectangle rect in drie)
                    {

                        Graphics picGraphics = picUurLinks.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "4":
                    foreach (Rectangle rect in vier)
                    {

                        Graphics picGraphics = picUurLinks.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "5":
                    foreach (Rectangle rect in vijf)
                    {

                        Graphics picGraphics = picUurLinks.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "6":
                    foreach (Rectangle rect in zes)
                    {

                        Graphics picGraphics = picUurLinks.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "7":
                    foreach (Rectangle rect in zeven)
                    {

                        Graphics picGraphics = picUurLinks.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "8":
                    foreach (Rectangle rect in acht)
                    {

                        Graphics picGraphics = picUurLinks.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "9":
                    foreach (Rectangle rect in negen)
                    {

                        Graphics picGraphics = picUurLinks.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
            }
            #endregion

            #endregion
        }


        private void pnlUur_Paint(object sender, PaintEventArgs e)
        {

        }
        private DateTime tijd = DateTime.Now;

        private void drawTimeSeconde()
        {
            Graphics picGraphicsFull = picSecondeLinks.CreateGraphics();
            picGraphicsFull.Clear(picSecondeLinks.BackColor);
            picGraphicsFull = picSecondeRechts.CreateGraphics();
            picGraphicsFull.Clear(picSecondeRechts.BackColor);


            #region Seconden


            Pen pen = new Pen(Color.Red);
            SolidBrush brush = new SolidBrush(Color.Red);

            tijd = DateTime.Now;


            string secondeEerst, secondeTweede;

            #region secondeTweede

            if (tijd.Second.ToString().ToCharArray().Length == 1)
            {
                secondeTweede = tijd.Second.ToString().Substring(0);
            }
            else
            {
                secondeTweede = tijd.Second.ToString().Substring(1, 1);
            }


            switch (secondeTweede)
            {

                case "0":
                    foreach (Rectangle rect in nul)
                    {


                        Graphics picGraphics = picSecondeRechts.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;

                case "1":
                    foreach (Rectangle rect in een)
                    {

                        Graphics picGraphics = picSecondeRechts.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "2":
                    foreach (Rectangle rect in twee)
                    {

                        Graphics picGraphics = picSecondeRechts.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "3":
                    foreach (Rectangle rect in drie)
                    {

                        Graphics picGraphics = picSecondeRechts.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "4":
                    foreach (Rectangle rect in vier)
                    {

                        Graphics picGraphics = picSecondeRechts.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "5":
                    foreach (Rectangle rect in vijf)
                    {

                        Graphics picGraphics = picSecondeRechts.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "6":
                    foreach (Rectangle rect in zes)
                    {

                        Graphics picGraphics = picSecondeRechts.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "7":
                    foreach (Rectangle rect in zeven)
                    {

                        Graphics picGraphics = picSecondeRechts.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "8":
                    foreach (Rectangle rect in acht)
                    {

                        Graphics picGraphics = picSecondeRechts.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "9":
                    foreach (Rectangle rect in negen)
                    {

                        Graphics picGraphics = picSecondeRechts.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
            }

            #endregion



            #region secondeEerst

            if (tijd.Second.ToString().ToCharArray().Length == 1)
            {
                secondeEerst = "0";
            }
            else
            {
                secondeEerst = tijd.Second.ToString().Substring(0, 1);
            }


            switch (secondeEerst)
            {

                case "0":
                    foreach (Rectangle rect in nul)
                    {


                        Graphics picGraphics = picSecondeLinks.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;

                case "1":
                    foreach (Rectangle rect in een)
                    {

                        Graphics picGraphics = picSecondeLinks.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "2":
                    foreach (Rectangle rect in twee)
                    {

                        Graphics picGraphics = picSecondeLinks.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "3":
                    foreach (Rectangle rect in drie)
                    {

                        Graphics picGraphics = picSecondeLinks.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "4":
                    foreach (Rectangle rect in vier)
                    {

                        Graphics picGraphics = picSecondeLinks.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "5":
                    foreach (Rectangle rect in vijf)
                    {

                        Graphics picGraphics = picSecondeLinks.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "6":
                    foreach (Rectangle rect in zes)
                    {

                        Graphics picGraphics = picSecondeLinks.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "7":
                    foreach (Rectangle rect in zeven)
                    {

                        Graphics picGraphics = picSecondeLinks.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "8":
                    foreach (Rectangle rect in acht)
                    {

                        Graphics picGraphics = picSecondeLinks.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "9":
                    foreach (Rectangle rect in negen)
                    {

                        Graphics picGraphics = picSecondeLinks.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
            }
            #endregion

            #endregion

            #region Minuten
            #region MinuutRechts

            #endregion

            #region MinuutLinks

            #endregion
            #endregion


            pen.Dispose();
            brush.Dispose();




        }

        private void tmrStartMinuten_Tick(object sender, EventArgs e)
        {
            drawMinuten();
            tmrStartMinuten.Interval = 60000;
        }

        private void drawMinuten()
        {
            Graphics picGraphicsFull = picMinuutLinks.CreateGraphics();
            picGraphicsFull.Clear(picMinuutLinks.BackColor);
            picGraphicsFull = picMinuutRechts.CreateGraphics();
            picGraphicsFull.Clear(picMinuutRechts.BackColor);


            #region Minuten


            Pen pen = new Pen(Color.Red);
            SolidBrush brush = new SolidBrush(Color.Red);

            tijd = DateTime.Now;


            string minuutEerste, minuutTweede;

            #region secondeTweede

            if (tijd.Minute.ToString().ToCharArray().Length == 1)
            {
                minuutTweede = tijd.Minute.ToString().Substring(0);
            }
            else
            {
                minuutTweede = tijd.Minute.ToString().Substring(1, 1);
            }


            switch (minuutTweede)
            {

                case "0":
                    foreach (Rectangle rect in nul)
                    {


                        Graphics picGraphics = picMinuutRechts.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;

                case "1":
                    foreach (Rectangle rect in een)
                    {

                        Graphics picGraphics = picMinuutRechts.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "2":
                    foreach (Rectangle rect in twee)
                    {

                        Graphics picGraphics = picMinuutRechts.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "3":
                    foreach (Rectangle rect in drie)
                    {

                        Graphics picGraphics = picMinuutRechts.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "4":
                    foreach (Rectangle rect in vier)
                    {

                        Graphics picGraphics = picMinuutRechts.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "5":
                    foreach (Rectangle rect in vijf)
                    {

                        Graphics picGraphics = picMinuutRechts.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "6":
                    foreach (Rectangle rect in zes)
                    {

                        Graphics picGraphics = picMinuutRechts.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "7":
                    foreach (Rectangle rect in zeven)
                    {

                        Graphics picGraphics = picMinuutRechts.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "8":
                    foreach (Rectangle rect in acht)
                    {

                        Graphics picGraphics = picMinuutRechts.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "9":
                    foreach (Rectangle rect in negen)
                    {

                        Graphics picGraphics = picMinuutRechts.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
            }

            #endregion



            #region minuutEerste

            if (tijd.Minute.ToString().ToCharArray().Length == 1)
            {
                minuutEerste = "0";
            }
            else
            {
                minuutEerste = tijd.Minute.ToString().Substring(0, 1);
            }


            switch (minuutEerste)
            {

                case "0":
                    foreach (Rectangle rect in nul)
                    {


                        Graphics picGraphics = picMinuutLinks.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;

                case "1":
                    foreach (Rectangle rect in een)
                    {

                        Graphics picGraphics = picMinuutLinks.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "2":
                    foreach (Rectangle rect in twee)
                    {

                        Graphics picGraphics = picMinuutLinks.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "3":
                    foreach (Rectangle rect in drie)
                    {

                        Graphics picGraphics = picMinuutLinks.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "4":
                    foreach (Rectangle rect in vier)
                    {

                        Graphics picGraphics = picMinuutLinks.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "5":
                    foreach (Rectangle rect in vijf)
                    {

                        Graphics picGraphics = picMinuutLinks.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "6":
                    foreach (Rectangle rect in zes)
                    {

                        Graphics picGraphics = picMinuutLinks.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "7":
                    foreach (Rectangle rect in zeven)
                    {

                        Graphics picGraphics = picMinuutLinks.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "8":
                    foreach (Rectangle rect in acht)
                    {

                        Graphics picGraphics = picMinuutLinks.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "9":
                    foreach (Rectangle rect in negen)
                    {

                        Graphics picGraphics = picMinuutLinks.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
            }
            #endregion

            #endregion

        }


        private void tmrStartMilliseconden_Tick(object sender, EventArgs e)
        {

            drawMilliseconden();
            }

        private void drawMilliseconden()
        {

            Graphics picGraphicsFull = picMilliseconde.CreateGraphics();
            picGraphicsFull.Clear(picMilliseconde.BackColor);
            Pen pen = new Pen(Color.Red);
            SolidBrush brush = new SolidBrush(Color.Red);

            tijd = DateTime.Now;

            string milli = tijd.Millisecond.ToString().Substring(0,1);
           //   MessageBox.Show(milli);
            switch (milli)
            {

                case "0":
                    foreach (Rectangle rect in nul)
                    {


                        Graphics picGraphics = picMilliseconde.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;

                case "1":
                    foreach (Rectangle rect in een)
                    {

                        Graphics picGraphics = picMilliseconde.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "2":
                    foreach (Rectangle rect in twee)
                    {

                        Graphics picGraphics = picMilliseconde.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "3":
                    foreach (Rectangle rect in drie)
                    {

                        Graphics picGraphics = picMilliseconde.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "4":
                    foreach (Rectangle rect in vier)
                    {

                        Graphics picGraphics = picMilliseconde.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "5":
                    foreach (Rectangle rect in vijf)
                    {

                        Graphics picGraphics = picMilliseconde.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "6":
                    foreach (Rectangle rect in zes)
                    {

                        Graphics picGraphics = picMilliseconde.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "7":
                    foreach (Rectangle rect in zeven)
                    {

                        Graphics picGraphics = picMilliseconde.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "8":
                    foreach (Rectangle rect in acht)
                    {

                        Graphics picGraphics = picMilliseconde.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;
                case "9":
                    foreach (Rectangle rect in negen)
                    {

                        Graphics picGraphics = picMilliseconde.CreateGraphics();

                        picGraphics.DrawRectangle(pen, rect);
                        picGraphics.FillRectangle(brush, rect);
                        picGraphics.Dispose();
                    }
                    break;

            }
        }

      


        private void tmrStart_Tick(object sender, EventArgs e)
        {
            //SolidBrush myBrush = new SolidBrush(Color.FromArgb(80, 200, 0, 0));
            //Graphics picGraphics = pnlUurLinks.CreateGraphics();
            //picGraphics.FillRectangle(myBrush, Top);// top  links


            //picGraphics.FillRectangle(myBrush, LinksTop);//links top
            //picGraphics.FillRectangle(myBrush, LinksBot);//links bot


            //picGraphics.FillRectangle(myBrush, Bot);// bot  links


            //picGraphics.FillRectangle(myBrush, RechtsTop);//rechts top
            //picGraphics.FillRectangle(myBrush, RechtsBot);//rechts bot

            //picGraphics.FillRectangle(myBrush, Mid);// mid  links



            drawTimeSeconde();
            tmrStartSeconden.Interval = 1000;
        }


    }
}
