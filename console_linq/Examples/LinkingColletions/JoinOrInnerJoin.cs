using console_linq.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_linq.Examples.LinkingColletions
{
    public static class JoinOrInnerJoin
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
            };

            var employeesAndCompanies = employees.Join(companies, e => e.CompanyId, c => c.Id, (employee, company) => new
            {
                Employee = employee,
                Company = company
            });

            foreach(var item in employeesAndCompanies)
            {
                Console.WriteLine($"{item.Employee.Name} works at {item.Company.Name}");
            }

            //Query Syntax
            var employeesAndCompanies_2 = from e in employees
                                          join c in companies
                                          on e.CompanyId equals c.Id
                                          select new
                                          {
                                              Employee = e,
                                              Company = c
                                          };
            Console.WriteLine("-----------------------------------");
            foreach (var item in employeesAndCompanies_2)
            {
                Console.WriteLine($"{item.Employee.Name} works at {item.Company.Name}");
            }
        }
    }
}
