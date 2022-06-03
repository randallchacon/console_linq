using console_linq.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_linq.Examples.LinkingColletions
{
    public static class GroupJoinOrLeftJoin
    {
        public static void Main()
        {
            var employees = new List<Employee>() {
                new Employee { Name = "Kevin", CompanyId = 1},
                new Employee { Name = "Marcela", CompanyId = 1},
                new Employee { Name = "Melissa", CompanyId = 2},
                new Employee { Name = "Minor", CompanyId = 3},
                new Employee { Name = "Pedro", CompanyId = 3},
                new Employee { Name = "Paula", CompanyId = 2},
                new Employee { Name = "Mónica"},
                new Employee { Name = "Monserrat", CompanyId = 2},
            };

            var companies = new List<Company>()
            {
                new Company { Id = 1, Name = "DXC"},
                new Company { Id = 2, Name = "GAP" },
                new Company { Id = 3, Name = "Intertec" },
                new Company { Id = 4, Name = "Concentrix" },
            };

            var companiesAndTheirEmployees = companies.GroupJoin(employees, e => e.Id, c => c.CompanyId,
                (company, employees) => new { 
                    Company = company,
                    Employees = employees
                });

            foreach (var item in companiesAndTheirEmployees)
            {
                Console.WriteLine($"{item.Company.Name} Company has these workers: ");
                foreach(var e in item.Employees)
                {
                    Console.WriteLine($"- {e.Name}");
                }
            }            
            Console.WriteLine("-----------------------------------");

            //Query syntax
            var companiesAndTheirEmployees_2 = from c in companies
                                               join e in employees
                                               on c.Id equals e.CompanyId into employees2
                                               select new
                                               {
                                                   Company = c,
                                                   Employees = employees2
                                               };

            foreach (var item in companiesAndTheirEmployees_2)
            {
                Console.WriteLine($"{item.Company.Name} Company has these workers: ");
                foreach (var e in item.Employees)
                {
                    Console.WriteLine($"- {e.Name}");
                }
            }
        }
    }
}
