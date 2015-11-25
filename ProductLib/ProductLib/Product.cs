using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLib
{
    public class Product
    {

    

        #region Props
    private int code;
        private double prijs;

        public double Prijs
        {
            get { return prijs; }
            set { prijs = value; }
        }

        public int Code
        {
            get { return code; }
            set { code = value; }
        }
        #endregion

        #region Constructors
        public Product()
        {

        }

        public Product(int code, double prijs)
        {
            this.Code = code;
             this.Prijs = prijs;
        }

        public Product(Product product)
        {
            product = this;
        }
        #endregion

        #region Methodes

        public virtual String ToonDetails()
        {


            return this.Code +" :  " + this.Prijs.ToString("C2");
        }

        #endregion

    }
}
