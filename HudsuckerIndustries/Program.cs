using System;
using System.Collections.Generic;

namespace HudsuckerIndustries
{
    class Program
    {
        public class Company
        {
            public string Name { get; }
            public DateTime CreatedOn { get; }
            public List<Employee> Employees { get; set; }
            Dictionary<string, List<Employee>> EmployeeDict;

            public Company(string name, DateTime createdOn)
            {
                Name = name;
                CreatedOn = createdOn;
                EmployeeDict = new Dictionary<string, List<Employee>>();
                EmployeeDict[name + "Employees"] = new List<Employee>();
            }

            public void AddEmployee(string name, string jobTitle, DateTime startDate)
            {
                var newEmployee = new Employee(name, jobTitle, startDate);
                EmployeeDict[Name + "Employees"].Add(newEmployee);
            }

            public void RemoveEmployee(string name)
            {
                var removeEm = Employees.Find(employee => employee.Name == name);
                EmployeeDict[Name + "Employees"].Remove(removeEm);
            }

            public void ListEmployees()
            {
                foreach(Employee emp in Employees)
                {
                    Console.WriteLine(emp.Name);
                }
            }

        }
        static void Main(string[] args)
        {
            
        }
    }
}
