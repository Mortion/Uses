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
            decimal totaal = 0;
            totaal = Prijs;
            return totaal;
        }

        public string FactuurtekstWeergeven()
        {
            string tekst = string.Empty;
           return tekst = "Volgende artikelen heeft u aangeschaft"+ Environment.NewLine + "_______________________________";
        }

        public override string ToString()
        {
            string tekst = string.Empty;
            return tekst = this.Aantal+" stuk(s) van " + this.Naam + ": " + this.Prijs.ToString("C2");
        }

    }
}
&