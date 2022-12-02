using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataTableServerSide.UI.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string Location { get; set; }
        public int Age { get; set; }
        public DateTime StartDate { get; set; }
        public string StartDateString { get; set; }
        public int Salary { get; set; }
        public bool IsActive { get; set; }=true;

        public  IEnumerable<Employee> GetEmployees() 
        { 
            var employees = new List<Employee>();
            employees.Add(new Employee {Name="Muhammet",Position="Developer",Location="İstanbul",Age=31,StartDate=DateTime.Now.AddYears(-5),StartDateString= DateTime.Now.AddYears(-5).ToShortDateString(),Salary=6000 });
            employees.Add(new Employee { Name = "Gökhan", Position = "Developer", Location = "İstanbul", Age = 31, StartDate = DateTime.Now.AddYears(-5), StartDateString = DateTime.Now.AddYears(-5).ToShortDateString(), Salary = 6000 });
            employees.Add(new Employee { Name = "İrem", Position = "Developer", Location = "İstanbul", Age = 31, StartDate = DateTime.Now.AddYears(-5), StartDateString = DateTime.Now.AddYears(-5).ToShortDateString(), Salary = 6000 });
            employees.Add(new Employee { Name = "Tuba", Position = "Developer", Location = "İstanbul", Age = 31, StartDate = DateTime.Now.AddYears(-5), StartDateString = DateTime.Now.AddYears(-5).ToShortDateString(), Salary = 6000 });
            employees.Add(new Employee { Name = "Ali", Position = "Developer", Location = "İstanbul", Age = 31, StartDate = DateTime.Now.AddYears(-5), StartDateString = DateTime.Now.AddYears(-5).ToShortDateString(), Salary = 6000 });
            employees.Add(new Employee { Name = "Veli", Position = "Developer", Location = "İstanbul", Age = 31, StartDate = DateTime.Now.AddYears(-5), StartDateString = DateTime.Now.AddYears(-5).ToShortDateString(), Salary = 6000 });
            employees.Add(new Employee { Name = "Ahmet", Position = "Developer", Location = "İstanbul", Age = 31, StartDate = DateTime.Now.AddYears(-5), StartDateString = DateTime.Now.AddYears(-5).ToShortDateString(), Salary = 6000 });
            employees.Add(new Employee { Name = "Mehmet", Position = "Developer", Location = "İstanbul", Age = 31, StartDate = DateTime.Now.AddYears(-5), StartDateString = DateTime.Now.AddYears(-5).ToShortDateString(), Salary = 6000 });
            employees.Add(new Employee { Name = "Hakan", Position = "Developer", Location = "İstanbul", Age = 31, StartDate = DateTime.Now.AddYears(-5), StartDateString = DateTime.Now.AddYears(-5).ToShortDateString(), Salary = 6000 });
            employees.Add(new Employee { Name = "Hüseyin", Position = "Developer", Location = "İstanbul", Age = 31, StartDate = DateTime.Now.AddYears(-5), StartDateString = DateTime.Now.AddYears(-5).ToShortDateString(), Salary = 6000 });
            employees.Add(new Employee { Name = "Koray", Position = "Developer", Location = "İstanbul", Age = 31, StartDate = DateTime.Now.AddYears(-5), StartDateString = DateTime.Now.AddYears(-5).ToShortDateString(), Salary = 6000 });
            employees.Add(new Employee { Name = "Anıl", Position = "Developer", Location = "İstanbul", Age = 31, StartDate = DateTime.Now.AddYears(-5), StartDateString = DateTime.Now.AddYears(-5).ToShortDateString(), Salary = 6000 });
            employees.Add(new Employee { Name = "Gencay", Position = "Developer", Location = "İstanbul", Age = 31, StartDate = DateTime.Now.AddYears(-5), StartDateString = DateTime.Now.AddYears(-5).ToShortDateString(), Salary = 6000 });
            employees.Add(new Employee { Name = "Mert", Position = "Developer", Location = "İstanbul", Age = 31, StartDate = DateTime.Now.AddYears(-5), StartDateString = DateTime.Now.AddYears(-5).ToShortDateString(), Salary = 6000 });
            employees.Add(new Employee { Name = "Okan", Position = "Developer", Location = "İstanbul", Age = 31, StartDate = DateTime.Now.AddYears(-5), StartDateString = DateTime.Now.AddYears(-5).ToShortDateString(), Salary = 6000 });
            employees.Add(new Employee { Name = "Senem", Position = "Developer", Location = "İstanbul", Age = 31, StartDate = DateTime.Now.AddYears(-5), StartDateString = DateTime.Now.AddYears(-5).ToShortDateString(), Salary = 6000 });
            employees.Add(new Employee { Name = "Özge", Position = "Developer", Location = "İstanbul", Age = 31, StartDate = DateTime.Now.AddYears(-5), StartDateString = DateTime.Now.AddYears(-5).ToShortDateString(), Salary = 6000 });
            employees.Add(new Employee { Name = "Öznur", Position = "Developer", Location = "İstanbul", Age = 31, StartDate = DateTime.Now.AddYears(-5), StartDateString = DateTime.Now.AddYears(-5).ToShortDateString(), Salary = 6000 });
            employees.Add(new Employee { Name = "Rıdvan", Position = "Developer", Location = "İstanbul", Age = 31, StartDate = DateTime.Now.AddYears(-5), StartDateString = DateTime.Now.AddYears(-5).ToShortDateString(), Salary = 6000 ,IsActive=false});
            employees.Add(new Employee { Name = "Merve", Position = "Developer", Location = "İstanbul", Age = 31, StartDate = DateTime.Now.AddYears(-5), StartDateString = DateTime.Now.AddYears(-5).ToShortDateString(), Salary = 6000, IsActive = false });
            employees.Add(new Employee { Name = "Ayşe", Position = "Developer", Location = "İstanbul", Age = 31, StartDate = DateTime.Now.AddYears(-5), StartDateString = DateTime.Now.AddYears(-5).ToShortDateString(), Salary = 6000, IsActive = false });

            return employees;
        }

    }
}