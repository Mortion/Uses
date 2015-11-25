using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefeningadresBoek
{
    interface IAdresBoekService
    {
         List<AdresGegeven> GetAll();
         void AdresOpslaan(AdresGegeven adres);
         void AdresVerwijderen(int ID);

    }
}
