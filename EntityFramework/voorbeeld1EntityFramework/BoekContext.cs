using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voorbeeld1EntityFramework
{
    class BoekContext : DbContext
    {
        public DbSet<Boek> Boeken { get; set; }

    }
}
