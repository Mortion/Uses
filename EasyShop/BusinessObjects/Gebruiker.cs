using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Gebruiker
    {
        public int Id { get; set; }
        public string Gebruikersnaam { get; set; }
        public List<Recept> FavorieteRecepten { get; set; }
        public List<DateTime> ThuisSchema { get; set; }
        public bool IsKok { get; set; }

        public string Paswoord { get; private set; }

        public Gebruiker()
        {
                
        }
        public bool SetPassword(string pw1,string pw2)
        {
            if (pw1.Equals(pw2))
            {

                Paswoord = pw1;
                return true;
            }
            else
            {
                return false;

            }



        }


    }
}
