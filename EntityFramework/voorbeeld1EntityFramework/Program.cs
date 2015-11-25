using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voorbeeld1EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var db = new BoekContext())
            {
                Boek b = new Boek()
                {
                    Auteur = "Peter Spaas",
                    Titel = "SQL voor dummy's",
                    Jaartal = 2011,
                    ISBNNummer = "123/12.23.23"
                };

                db.Boeken.Add(b);
                db.SaveChanges();
            }



        }
    }
}
