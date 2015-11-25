using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLib
{
   public class Auto : Product
    {
        #region Props
        private int wielen;
        private String kleur;

        public String Kleur
        {
            get { return kleur; }
            set { kleur = value; }
        }

        public int Wielen
        {
            get { return wielen; }
            set { wielen = value; }
        }

        #endregion


        #region Constructor
        public Auto() : base()
        {

        }
        public Auto(int wielen, String kleur) : base()
        {
            this.Wielen = wielen;
            this.Kleur = kleur;
        }

        public Auto(Product product,int wielen, String kleur) : base()
        {
            this.Code = product.Code;
            this.Prijs = product.Prijs;
            this.Wielen = wielen;
            this.Kleur = kleur;
        }
        #endregion

        public override string ToonDetails()
        {
            return base.ToonDetails() + " " + this.Kleur +"  " + this.Wielen + " wielen.";
        }

    }
}
