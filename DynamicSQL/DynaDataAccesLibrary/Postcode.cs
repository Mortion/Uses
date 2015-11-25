using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynaDataAccesLibrary
{
    public class Postcode
    {
        public int Id { get; set; }
        public int PostalCode { get; set; }
        public String City { get; set; }

        public Postcode()
        {

        }
        public Postcode(int Id, int Postal, String City)
        {
            this.Id = Id;
            this.PostalCode = Postal;
            this.City = City;
        }

    }
}
