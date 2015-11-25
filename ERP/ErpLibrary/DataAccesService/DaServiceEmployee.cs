using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ErpLibrary.H_R;

namespace ErpLibrary.DataAccesService
{
    public class DaServiceEmployee : IDaService<Employee>
    {
        
   

        public DaServiceEmployee()
        {

        }

        public void Add(Employee item)
        {
            using (var context = new ServiceContextEmployee())
            {
                context.Employees.Add(item);
                context.SaveChanges();
            }

        }

        public void Delete(Employee item)
        {
            using (var context = new ServiceContextEmployee())
            {
                context.Employees.Remove(item);
                context.SaveChanges();
            }
        }

        public Employee GetSelect(Employee item)
        {
            using (var context = new ServiceContextEmployee())
            {
              return  context.Employees.SingleOrDefault(user => user.EmployeeNumber == item.EmployeeNumber);
            }
        }

        public List<Employee> GetAll()
        {
            using (var context = new ServiceContextEmployee())
            {
                return context.Employees.ToList();
            }
            
        }

       
    }
}
