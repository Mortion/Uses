using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefeningadresBoek
{
    public class AdresService : IAdresBoekService
    {
        public List<AdresGegeven> GetAll()
        {
            using (var context = new AdresContext())
            {
                return context.Adressen.ToList();
            }
        }
        public void AdresOpslaan(AdresGegeven adres)
        {
            using (var context = new AdresContext())
            {
                
                context.Adressen.Add(adres);
                context.SaveChanges();
            }
        }
        public void AdresVerwijderen(int ID)
        {
            using (var context = new AdresContext())
            {
               AdresGegeven adres = context.Adressen.Find(ID);
               context.Adressen.Remove(adres);
               context.SaveChanges();
            }
        }
    }
}
