using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ErpLibrary;
using ErpLibrary.DataAccesService;
using ErpLibrary.Enums;
using ErpLibrary.H_R;

namespace ErpAlgoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee()
            {
                Address = "Halfbunderweg 23",
                Birthdate = DateTime.Parse("27/04/1994"),
                City = "Hemiksem",
                Email = "jarrik@mvcbvba.be",
                FirstName = "Jarrik",
                Name = "Van Camp",
                Gender = Gender.Male,
                JobType = JobType.Programmer,
                NationalRegistryNumber = "19940427666182"

            };

            DaServiceEmployee serviceEmployee = new DaServiceEmployee();

            serviceEmployee.Add(emp);

            foreach (var emps in serviceEmployee.GetAll())
            {
                Console.WriteLine(emps.ToString());
            }

            Console.Read();

        }

     static   DateTime RandomDay()
        {
            DateTime start = new DateTime(1995, 1, 1);
            Random gen = new Random();

            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }
    }
}
