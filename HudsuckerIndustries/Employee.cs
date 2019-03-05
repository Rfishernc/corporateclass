using System;
using System.Collections.Generic;
using System.Text;

namespace HudsuckerIndustries
{
    class Employee
    {
        public string Name { get; }
        private string JobTitle { get; set; }
        private DateTime StartDate { get; set; }

        public Employee(string name, string jobTitle, DateTime startDate)
        {
            Name = name;
            JobTitle = jobTitle;
            StartDate = startDate;
        }
    }
}
