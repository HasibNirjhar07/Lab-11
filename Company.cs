using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    public class Company
    {
        private List<Employee> employees = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void RemoveEmployee(Employee employee)
        {
            employees.Remove(employee);
        }

        public void ListEmployees()
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Name} ({employee.GetType().Name})");
            }
        }

        public List<Employee> SearchByName(string name)
        {
            return employees.FindAll(e => e.Name.Contains(name));
        }

        public List<Employee> SearchByJobTitle(string jobTitle)
        {
            return employees.FindAll(e => e is Regular_Employee && ((Regular_Employee)e).JobTitle.Contains(jobTitle));
        }

        public List<Employee> SearchByDepartment(string department)
        {
            return employees.FindAll(e => e is Regular_Employee && ((Regular_Employee)e).Department.Contains(department));
        }

    }
}
