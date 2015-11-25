using System;

using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeertjesLibrary
{
   public class PlusheBeertje : Beertje
    {
        public String Wasprogramma { get; set; }

        public PlusheBeertje():base()
        {
            
        }

        public PlusheBeertje(String Naam, Bitmap Afbeelding, String Wasprogramma)
            : base(Naam, Afbeelding)
        {
            this.Wasprogramma = Wasprogramma;
        }

        public override string BeerBeschrijving()
        {
            return this.Naam + " Wasprogramma:" + this.Wasprogramma; ;
        }
    }
}
