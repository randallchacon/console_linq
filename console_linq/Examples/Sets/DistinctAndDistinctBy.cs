using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using console_linq.Entities;
using console_linq.Functions;

namespace console_linq.Examples.Sets
{
    public static class DistinctAndDistinctBy
    {
        public static void Main() { 

            int[] numbers = { 1, 2, 3, 4, 1, 2, 5, 2, 1 };

            var people = new List<Person>() { 
                new Person() { Name = "Randall", CompanyId = 1},
                new Person() { Name = "Fabiola", CompanyId = 2},
                new Person() { Name = "Carlos", CompanyId = 1},
                new Person() { Name = "Randall"},
            };

            var NonRepeatingNumbers = numbers.Distinct();

            foreach (var n in NonRepeatingNumbers) {
                Console.Write(n + " ");
            }

            Console.WriteLine("\n---------------------------");

            var NonRepeatingNames = people.DistinctBy(p => p.Name);

            foreach (var x in NonRepeatingNames) {
                Console.WriteLine(x.Name);
            }

            //Query Syntax
            var NonRepeatingNumbers_2 = from n in numbers.Distinct()
                                        select n;

            var NonRepeatingNames_2 = from p in people.DistinctBy(p => p.Name)
                                      select p;
        }
    }
}
