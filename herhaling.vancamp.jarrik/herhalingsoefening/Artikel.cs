using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herhalingsoefening
{
    public class Artikel: Product
    {
        #region Public Properties
        public int Aantal{get;set;}
        public decimal Totaal {get;set;}
        #endregion

        #region Constructor(s)
        public Artikel()
        {
            this.Aantal= 0;
        }

        public Artikel(int aantal): base()
        {
            this.Aantal = aantal;
        }
        #endregion

        public decimal BerekenSubTotaal()
        {
            Totaal = Prijs*Aantal;
            return Totaal;
        }

        public string FactuurtekstWeergeven()
        {
            decimal test = Convert.ToDecimal(this.Prijs) * this.Aantal;
            string tekst;
            return tekst = this.Aantal + " stuk(s) van " + this.Naam + ": " + this.Prijs.ToString("C2");
            
        }

        public override string ToString()
        {
            string tekst;
            return tekst = this.Code + " " + this.Naam + ": " + this.Prijs.ToString("C2") + " x" + this.Aantal;
        }

    }
}
