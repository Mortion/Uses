using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Product
    {
        public int Id { get; set; }
        public string Beschrijving { get; set; }
        public decimal Prijs { get; set; }

        public Product()
        {
                
        }


        public override string ToString() => $"{Beschrijving} : {Prijs.ToString("C2")}€";

    }
}
