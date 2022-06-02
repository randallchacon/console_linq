using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using console_linq.Entities;

namespace console_linq.Examples.Order
{
    public static class OrderByAndOrderByDescending
    {
        public static void Main()
        {
            var people = new People().peopleList;

            var peopleOrderByAge = people.OrderBy(p => p.Age);

            foreach(var person in peopleOrderByAge)
            {
                Console.WriteLine($"{person.Name} is {person.Age} years old.");
            }

            Console.WriteLine("----------------\n");

            var peopleOrderByAgeDescending = people.OrderByDescending(p => p.Age);

            foreach (var person in peopleOrderByAgeDescending)
            {
                Console.WriteLine($"{person.Name} is {person.Age} years old.");
            }

            int[] numbers = { 5, 10, 80, 12, 1, 9, 81 };

            Console.WriteLine("----------------\n");

            foreach (var n in numbers.OrderBy(n => n))
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("----------------\n");
            //Queries Syntax
            var numbers2 = from n in numbers
                           orderby n
                           select n;

            var peopleOrderByAgeDesc = from p in people
                                       orderby p.Age descending
                                       select p;

            foreach(var n in numbers2){
                Console.Write($"{n} ");
            }

            Console.WriteLine("\n----------------\n");
            foreach (var person in peopleOrderByAgeDesc)
            {
                Console.WriteLine($"{person.Name} is {person.Age} years old.");
            }
        }
    }
}
