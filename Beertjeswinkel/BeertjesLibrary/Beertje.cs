using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;



namespace BeertjesLibrary
{
    public abstract class Beertje
    {

        /**
         * 
         * Jarrik Van Camp 
         * 
         **/

        public String Naam { get; set; }
        public Bitmap Afbeelding { get; set; }



        public Beertje()
        {
            this.Naam = "";
            this.Afbeelding = null;
        }

        internal Beertje(String Naam, Bitmap Afbeelding)
        {
            this.Naam = Naam;
            this.Afbeelding = Afbeelding;

        }


        public abstract String BeerBeschrijving();

        public override string ToString()
        {
            return BeerBeschrijving();
        }

    }
}
