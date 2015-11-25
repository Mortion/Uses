using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ErpLibrary.Enums;

namespace ErpLibrary.H_R
{
    public class Employee : Person
    {
        public Gender Gender { get; set; }
        public JobType JobType { get; set; }
        public DateTime StartedWorking { get; set; }
        public String EmployeeNumber { get; private set; }
        public String NationalRegistryNumber { get; set; }

        public Employee() : base()
        {
            SetEmployeeNumber();
        }

        public Employee(string name, string firstName, string email, string address, string city, string postalCode,
            Gender gender, JobType jobType, DateTime startedWorking, String nationalRegistryNumber)
            : base(name, firstName, email, address, city, postalCode)
        {
            Gender = gender;
            JobType = jobType;
            StartedWorking = startedWorking;
            NationalRegistryNumber = nationalRegistryNumber;
            SetEmployeeNumber();
        }

        private void SetEmployeeNumber()
        {
            var random = new Random();
            EmployeeNumber = null;

            int add = 0;
            add += random.Next(9);
            for (int i = 0; i < 3; i++)
            {
                char c = random.Next(9).ToString().ToCharArray()[0];
                EmployeeNumber += c;
            }


            EmployeeNumber += add;

            
          
            var count = 5;
            while (count > 0)
            {
                EmployeeNumber += random.Next(9);
                count--;
            }

            if (random.Next(2) == 0)
            {
                 Array.Reverse(EmployeeNumber.ToCharArray());
                EmployeeNumber += 1;
            }
            else
            {
                EmployeeNumber += 0;
            }
            

           
        }

        public override string ToString()
        {
            return EmployeeNumber + " " + base.ToString();
        }
    }
}
