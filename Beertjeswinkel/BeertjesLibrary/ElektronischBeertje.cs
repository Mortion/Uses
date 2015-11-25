using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeertjesLibrary
{
   public class ElektronischBeertje : Beertje
    {
        public int AantalBatterijen { get; set; }

        public ElektronischBeertje() : base()
        {
                
        }

        public ElektronischBeertje(String Naam, Bitmap Afbeelding, int AantalBatterijen)
            : base(Naam, Afbeelding)
        {
            this.AantalBatterijen = AantalBatterijen;
        }


        public override string BeerBeschrijving()
        {
            return this.Naam +" Aantal Batterijen: " +this.AantalBatterijen ;
        }
    }
}
