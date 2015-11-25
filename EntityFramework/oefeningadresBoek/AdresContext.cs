using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefeningadresBoek
{
    class AdresContext : DbContext
    {
        public DbSet<AdresGegeven> Adressen { get; set; }

        public AdresContext()
        {
             Database.SetInitializer<AdresContext>(
                new DropCreateDatabaseIfModelChanges<AdresContext>());
        }

      

    }
}
