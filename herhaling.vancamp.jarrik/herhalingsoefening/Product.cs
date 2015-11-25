using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herhalingsoefening
{
    public class Product
    {

        #region Public Properties
        public String Code { get; set; }
        public String Naam { get; set; }
        public Decimal Prijs { get; set; }
        public String ProductDefinitie { get; private set; }
        #endregion
  

        #region Constructor(s)

        public Product()
        {
            this.Code = string.Empty;
            this.Naam = string.Empty;
            this.Prijs = 0;
        }

        public Product(String code, String naam, Decimal prijs)
        {
            this.Code = code;
            this.Naam = naam;
            this.Prijs = prijs;
        }

        public Product(Product product)
        {
            this.Code = product.Code;
            this.Naam = product.Naam;
            this.Prijs = product.Prijs;
        }
        #endregion

        public override string ToString()
        {
            string tekst;
            return tekst = this.Code + " " + this.Naam + ": "  + this.Prijs.ToString("C2");
        }
    }
}
