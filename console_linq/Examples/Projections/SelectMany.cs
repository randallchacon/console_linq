using console_linq.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_linq.Examples.Projections
{
    public static class SelectMany
    {
        public static void Main()
        {
            var customers = new List<Customer>() {
                new Customer { Name = "Alejandra", Phones = { "8888-5533", "7065-5599", "8585-8585" } },
                new Customer { Name = "Eduard", Phones = { "7800-5545", "8080-2222" } },
                new Customer { Name = "Thiago", Phones = { "2220-9999" } },         
                new Customer { Name = "Laura" }
            };

            var phones = customers.SelectMany(x => x.Phones).ToList();
            //var phones = customers.Select(x => x.Phones).ToList(); //Colletion of collections

            foreach (var t in phones)
            {
                Console.WriteLine(t);
            }

            //Select Many with 2 different collections
            int[] numbers = { 1, 2, 3 };

            var customerWithNumbers = customers.SelectMany(c => numbers, (customer, number) => new
            {
                Customer = customer,
                Number = number
            });
            Console.WriteLine("----------------\n");
            foreach (var item in customerWithNumbers)
            {
                Console.WriteLine($"{item.Customer.Name} - {item.Number}");
            }

            //People and phones
            var peoplePhones = customers.SelectMany(c => c.Phones, (customer, phone) => new
            {
                Customer = customer,
                Phone = phone
            });

            Console.WriteLine("----------------\n");
            foreach (var item in peoplePhones)
            {
                Console.WriteLine($"{item.Customer.Name} - {item.Phone}");
            }

            //Query Syntax
            var phones_2 = from c in customers
                           from p in c.Phones
                           select p;

            var customerWithNumbers_2 = from c in customers
                                      from n in numbers
                                      select new
                                      {
                                          Customer = c.Name,
                                          Number = n
                                      };
            bool end = true;
        }
    }
}
