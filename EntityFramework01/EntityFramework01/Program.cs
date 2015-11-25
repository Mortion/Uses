using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework01
{
    class Program
    {
        static void Main(string[] args)
        {
            Properties p = new Properties()
            {
                Name = "jarrik van camp",
                Email = "jarrik@email.com"

            };
            Service service = new Service();

            service.Add(p);

            List<Properties> props = new List<Properties>();
            props = service.GetAll();

            foreach (var prop in props)
            {
                Console.WriteLine(prop.ToString());
            }
            Console.Read();
        }
    }
}
