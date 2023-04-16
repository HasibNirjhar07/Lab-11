using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    public class Manager
    {
        public Regular_Employee Employee { get; set; }
        public List<Employee> ManagedEmployees { get; set; }

        public Manager(Regular_Employee employee)
        {
            Employee = employee;
            ManagedEmployees = new List<Employee>();
        }

        public void AddManagedEmployee(Employee employee)
        {
            ManagedEmployees.Add(employee);
        }

        public void RemoveManagedEmployee(Employee employee)
        {
            ManagedEmployees.Remove(employee);
        }

        public static explicit operator Manager(Employee v)
        {
            throw new NotImplementedException();
        }
    }
}
