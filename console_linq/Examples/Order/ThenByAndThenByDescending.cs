using console_linq.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_linq.Examples.Order
{
    public static class ThenByAndThenByDescending
    {
        public static void Main()
        {
            var people = new People().peopleList;

            var peopleOrderByAgeAndName = people.OrderBy(p => p.Age).ThenBy(p => p.Name);

            foreach (var person in peopleOrderByAgeAndName)
            {
                Console.WriteLine($"{person.Name} is {person.Age} years old.");
            }

            Console.WriteLine("----------------\n");
            var peopleOrderByAgeAndNameDesc = people.OrderBy(p => p.Age).ThenByDescending(p => p.Name);
            foreach (var person in peopleOrderByAgeAndNameDesc)
            {
                Console.WriteLine($"{person.Name} is {person.Age} years old.");
            }

            //Queries Syntax
            var peopleOrderByAgeAndName_2 = from p in people
                                            orderby p.Age, p.Name descending
                                            select p;

            Console.WriteLine("----------------\n");            
            foreach (var person in peopleOrderByAgeAndName_2)
            {
                Console.WriteLine($"{person.Name} is {person.Age} years old.");
            }
        }
    }
}
