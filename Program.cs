using Lab_11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    internal class Program
    {
        static void Main(string[] args)
        {  // Create a new company
            var company = new Company();

            // Add some employees to the company
            var john = new Regular_Employee("John Doe", "123 Main St", "555-1234", "john.doe@gmail.com", new DateTime(1985, 1, 1), new DateTime(2010, 1, 1), "Software Developer", 60000m, "IT");
            var jane = new Regular_Employee("Jane Smith", "456 Elm St", "555-5678", "jane.smith@gmail.com", new DateTime(1990, 1, 1), new DateTime(2016, 1, 1), "Marketing Specialist", 50000m, "Marketing");
            var bob = new Regular_Employee("Bob Johnson", "789 Oak St", "555-9012", "bob.johnson@outlook.com", new DateTime(1974, 1, 1), new DateTime(2000, 1, 1), "Sales Manager", 80000m, "Sales");
            var alice = new Regular_Employee("Alice Lee", "321 Pine St", "555-3456", "alice.lee@yahoo.com", new DateTime(1995, 1, 1), new DateTime(2020, 1, 1), "Human Resources Coordinator", 45000m, "Human Resources");

            company.AddEmployee(john);
            company.AddEmployee(jane);
            company.AddEmployee(bob);
            company.AddEmployee(alice);

            // Create some managers and executives
            var itManager = new Manager(john);
            itManager.AddManagedEmployee(jane);
            var salesManager = new Manager(bob);
            var ceo = new Executive(salesManager, 0.1m);

            // Add the managers and executives to the company
            company.AddEmployee(itManager.Employee);
            company.AddEmployee(salesManager.Employee);
            company.AddEmployee(ceo.Manager.Employee);

            // List all employees in the company
            Console.WriteLine("All employees:");
            company.ListEmployees();

            // Search for employees by name, job title, and department
            Console.WriteLine("Employees named 'John':");
            var johns = company.SearchByName("John");
            foreach (var employee in johns)
            {
                Console.WriteLine($"{employee.GetType().Name}: {employee.Name}");
                Console.WriteLine($"Age: {employee.CalculateAge()} years");
                Console.WriteLine($"Address: {employee.Address}");
                Console.WriteLine($"Phone: {employee.PhoneNumber}");
                Console.WriteLine($"Email: {employee.Email}");
                Console.WriteLine($"Date of Birth: {employee.DateOfBirth.ToShortDateString()}");
                Console.WriteLine($"Hire Date: {employee.HireDate.ToShortDateString()}");
                if (employee is Regular_Employee)
                {
                    var regularEmployee = (Regular_Employee)employee;
                    Console.WriteLine($"Job Title: {regularEmployee.JobTitle}");
                    Console.WriteLine($"Salary: {regularEmployee.Salary:C}");
                    Console.WriteLine($"Department: {regularEmployee.Department}");
                }
                if (employee is Manager)
                {
                    var manager = (Manager)employee;
                    Console.WriteLine("Managed Employees:");
                    foreach (var managedEmployee in manager.ManagedEmployees)
                    {
                        Console.WriteLine($"- {managedEmployee.Name}");
                    }
                }
                if (employee is Executive)
                {
                    var executive = (Executive)employee;
                    Console.WriteLine($"Bonus Percentage: {executive.BonusPercentage:P}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Employees with 'Manager' in their job title:");
            var managers = company.SearchByJobTitle("Manager");
            foreach (var employee in managers)
            {
                Console.WriteLine($"{employee.Name} ({employee.GetType().Name})");
            }

            Console.WriteLine("Employees in the 'IT' department:");
            var itEmployees = company.SearchByDepartment("IT");
            foreach (var employee in itEmployees)
            {
                Console.WriteLine($"{employee.Name} ({employee.GetType().Name})");
            }

            Console.ReadLine();
        }
    

}
    }

    