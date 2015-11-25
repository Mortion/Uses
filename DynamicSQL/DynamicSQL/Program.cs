using DynaDataAccesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            Postcode postal = new Postcode(1, 2620, "Hemiksem");
            DataAcces da = new DataAcces("postal");

            List<object> pcs = new List<object>();
            pcs.Add(postal);
            pcs.Add(postal);
            pcs.Add(postal);

            da.AddAll(pcs);

            Console.Read();

        }
    }
}
