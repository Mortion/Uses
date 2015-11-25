using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ErpLibrary.H_R;

namespace ErpLibrary.DataAccesService
{
    internal class ServiceContextEmployee : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public ServiceContextEmployee() : base("Data Source=localhost;Initial Catalog=dbErp;Integrated Security=True;Pooling=False")
        {

        }
    }
}
