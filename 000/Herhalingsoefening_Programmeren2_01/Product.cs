using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herhalingsoefening_Programmeren2_01
{
    public class Product
    {

        //private members, constructor, methodes

        #region Public Properties
        private int code = 0;
        private String naam = "";
        private double prijs = 0.0;
        private String productDefinitie = "";

        public String ProductDefinitie
        {
            get { return productDefinitie; }
            set { productDefinitie = value; }
        }

        public double Prijs
        {
            get { return prijs; }
            set { prijs = value; }
        }

        public String Naam
        {
            get { return naam; }
            set { naam = value; }
        }

        public int Code
        {
            get { return code; }
            set { code = value; }
        }
        #endregion

        #region Constructor
        public Product()
        {
            /**
             * 
             * INIT
             * 
             **/

            this.Code = 0;
            this.Naam = "";
            this.Prijs = 0.0;
            this.ProductDefinitie = "";
        }

        public Product(int code,String naam, double prijs)
        {
            this.Code = code;
            this.Naam = naam;
            this.Prijs = prijs;
        }


        //template voor latere functionaliteit

        public Product(Product product)
        {
            this.Code = product.Code;
            this.Naam = product.Naam;
            this.Prijs = product.Prijs;
        }

        #endregion

        #region Methodes: ALTIJD BEGINNEN MET EEN HOOFDLETTER!!!
        public override string ToString()
        {
            return "{" + Code + "} " + Naam + " €" + Prijs + " " + ProductDefinitie;
        }
        #endregion
    }
}
