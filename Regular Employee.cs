using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    public class Regular_Employee : Employee
    {
      

        public string JobTitle { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }

        public Regular_Employee(string name, string address, string phoneNumber, string email, DateTime dateOfBirth, DateTime hireDate, string jobTitle, decimal salary, string department) : base(name, address, phoneNumber, email, dateOfBirth, hireDate)
        {
            JobTitle = jobTitle;
            Salary = salary;
            Department = department;
        }


    }
}
