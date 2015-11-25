using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herhalingsoefening_Programmeren2_01
{
   public class Artikel : Product
    {

        private int aantal;

        public int Aantal
        {
            get { return aantal; }
            set { aantal = value; }
        }

        public Artikel()
        {

        }

        public Artikel(Product p, int aantal)
        {
            this.Code = p.Code;
            this.Naam = p.Naam;
            this.Prijs = p.Prijs;
            this.Aantal = aantal;
        }

        public double berekenSubtotaal()
        {
            double sub=0;

            sub = Prijs * Aantal;

            return sub;
        }

        public string factuurtekstWeergeven()
        {
            return Aantal + " stuk(s) van " + Naam + " = " + berekenSubtotaal();
        }

        public override string ToString()
        {
            return "{" + Code + "} " + Naam + " €" + Prijs + " " + ProductDefinitie + " X" + Aantal;
        }


    }
}
