using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNO
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }
        private string path = System.AppDomain.CurrentDomain.BaseDirectory.Substring(0, System.AppDomain.CurrentDomain.BaseDirectory.Length - 10);

        List<Kaart> BoekKaarten = new List<Kaart>();
        List<Kaart> HandSpeler = new List<Kaart>();
        List<Button> btnsHandSpeler = new List<Button>();
        Kaart OpenKaart = new Kaart();
        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            LaadKaarten();
            LaadAfbeeldingen();
            
            BoekKaarten.Shuffle();
          //  ToonKaarten();
            InitSpelbord();
            
          
        }

        private void InitSpelbord()
        {
            LaadHand();
            LaadOpenKaart();
        }

        private void LaadOpenKaart()
        {
            btnUnoOpenKaart.Image = BoekKaarten[0].Afbeelding;
            OpenKaart = BoekKaarten[0];
            BoekKaarten.RemoveAt(0);
        }

        private void LaadKaarten()
        {

            BoekKaarten.Add(new Kaart(0, KaartKleur.Blauw));

            for (int i = 1; i <= 9; i++)
            {
                BoekKaarten.Add(new Kaart(i, KaartKleur.Blauw));
                BoekKaarten.Add(new Kaart(i, KaartKleur.Blauw));
            }

            BoekKaarten.Add(new Kaart(0, KaartKleur.Geel));

            for (int i = 1; i <= 9; i++)
            {
                BoekKaarten.Add(new Kaart(i, KaartKleur.Geel));
                BoekKaarten.Add(new Kaart(i, KaartKleur.Geel));
            }
            BoekKaarten.Add(new Kaart(0, KaartKleur.Groen));

            for (int i = 1; i <= 9; i++)
            {
                BoekKaarten.Add(new Kaart(i, KaartKleur.Groen));
                BoekKaarten.Add(new Kaart(i, KaartKleur.Groen));
            }
            BoekKaarten.Add(new Kaart(0, KaartKleur.Rood));

            for (int i = 1; i <= 9; i++)
            {
                BoekKaarten.Add(new Kaart(i, KaartKleur.Rood));
                BoekKaarten.Add(new Kaart(i, KaartKleur.Rood));
            }

            lstTest.Items.Add(BoekKaarten.Count + "");

        }
        private void LaadAfbeeldingen()
        {
            foreach (Kaart k in BoekKaarten)
            {
                switch (k.Kaartkleur)
                {
                    case KaartKleur.Blauw:
                        //  MessageBox.Show(path + "refs\\KaartenUNO\\Blauw\\blauw_" + k.Waarde);
                        k.Afbeelding = new Bitmap(path + "refs\\KaartenUNO\\Blauw\\blauw_" + k.Waarde + ".png");

                        break;
                    case KaartKleur.Groen:
                        k.Afbeelding = new Bitmap(path + "refs\\KaartenUNO\\Groen\\groen_" + k.Waarde + ".png");
                        break;
                    case KaartKleur.Geel:
                        k.Afbeelding = new Bitmap(path + "refs\\KaartenUNO\\Geel\\geel_" + k.Waarde + ".png");
                        break;
                    case KaartKleur.Rood:
                        k.Afbeelding = new Bitmap(path + "refs\\KaartenUNO\\Rood\\rood_" + k.Waarde + ".png");

                        break;
                }

            }
        }

        private void LaadHand()
        {
            btnsHandSpeler.Add(btnHand1);
            btnsHandSpeler.Add(btnHand2);
            btnsHandSpeler.Add(btnHand3);
            btnsHandSpeler.Add(btnHand4);
            btnsHandSpeler.Add(btnHand5);
            btnsHandSpeler.Add(btnHand6);
            btnsHandSpeler.Add(btnHand7);
           
            for (int i = 0; i <= 3; i++)
            {
                Kaart k = BoekKaarten[0];
                HandSpeler.Add(k);
                btnsHandSpeler[i].Image = k.Afbeelding;
                BoekKaarten.RemoveAt(0);
            }

        }

        private void SpeelKaart(object sender, EventArgs e)
        { 
            Button btn = (Button)sender;
            string str = btn.Name.Substring(7);
            int nrKaart = int.Parse(str)-1;
          
            if((HandSpeler[nrKaart].Kaartkleur == OpenKaart.Kaartkleur) || (HandSpeler[nrKaart].Waarde == OpenKaart.Waarde))
            {
                MessageBox.Show("Test");
            }


        }

        private void ToonKaarten()
        {
            foreach (Kaart kaart in BoekKaarten)
            {
                lstTest.Items.Add(kaart.ToString());
            }
        }

    }
  
    static class MyExtensions
    {
        public static class ThreadSafeRandom
        {
            [ThreadStatic]
            private static Random Local;

            public static Random ThisThreadsRandom
            {
                get { return Local ?? (Local = new Random(unchecked(Environment.TickCount * 31 + Thread.CurrentThread.ManagedThreadId))); }
            }
        }
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = ThreadSafeRandom.ThisThreadsRandom.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
