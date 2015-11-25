using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace UNO
{
    public class Kaart
    {

        public Kaart()
        {

        }

        public int Waarde { get; set; }
        public KaartKleur Kaartkleur { get; set; }
        public Bitmap Afbeelding { get; set; }
        
        /// <summary>
        /// VB kaart(9,KaartKleur.Blauw);
        /// </summary>
        /// <param name="Waarde"></param>
        /// <param name="Kleur"></param>
        public Kaart(int Waarde,KaartKleur Kleur)
        {
            this.Waarde = Waarde;
            this.Kaartkleur = Kleur;
            this.Afbeelding = Afbeelding;
        }

        public override string ToString()
        {
            return this.Waarde +" " + this.Kaartkleur;
        }
    }

  public  enum KaartKleur {
        Groen,
        Rood,
        Blauw,
        Geel
    }

}
