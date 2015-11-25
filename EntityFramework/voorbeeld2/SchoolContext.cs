using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voorbeeld2
{
    class SchoolContext : DbContext
    {

        public DbSet<Student> Studenten { get; set; }
        public DbSet<Cursus> Cursussen { get; set; }

        public SchoolContext()
            : base("Data Source=localhost;Initial Catalog=SchoolDB;Integrated Security=True;Pooling=False")
        {
            Database.SetInitializer<SchoolContext>(
                new DropCreateDatabaseIfModelChanges<SchoolContext>());
        }

    }
}
