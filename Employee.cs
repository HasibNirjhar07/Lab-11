using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    public class Employee
    {
//internal object phoneNumber;

        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime HireDate { get; set; }

        public Employee(string name, string address, string phoneNumber, string email, DateTime dateOfBirth, DateTime hireDate)
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
            DateOfBirth = dateOfBirth;
            HireDate = hireDate;
        }

        public int CalculateAge()
        {
            var today = DateTime.Today;
            var age = today.Year - DateOfBirth.Year;
            if (DateOfBirth > today.AddYears(-age)) age--;
            return age;
        }

        public int CalculateYearsOfService()
        {
            var today = DateTime.Today;
            var years = today.Year - HireDate.Year;
            if (HireDate > today.AddYears(-years)) years--;
            return years;
        }
    }

}