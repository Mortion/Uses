using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework01
{
    public class Context : DbContext
    {
        public DbSet<Properties> props { get; set; }

        public Context() : base("Data Source=localhost;Initial Catalog=dbErp;Integrated Security=True;Pooling=False")
        {

        }
    }
}
