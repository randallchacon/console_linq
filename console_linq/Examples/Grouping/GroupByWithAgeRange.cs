using console_linq.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_linq.Examples.Grouping
{
    public static class GroupByWithAgeRange
    {
        public static void Main()
        {
            var people = new People().peopleList;

            var GroupByAgeRange = people.GroupBy(p => p.Age / 5);

            foreach(var group in GroupByAgeRange)
            {
                Console.WriteLine($"Group of people in the age range {group.Key * 5 } - {group.Key * 5 + 5 - 1}");

                foreach(var person in group)
                {
                    Console.WriteLine($"- {person.Name} (age: {person.Age})");
                }
            }

            //Query syntax
            var GroupByAgeRange_2 = from p in people
                                    group p by (p.Age / 5)
                                    into groups select groups;

            Console.WriteLine("--------------------------------------");
            foreach (var group in GroupByAgeRange_2)
            {
                Console.WriteLine($"Group of people in the age range {group.Key * 5 } - {group.Key * 5 + 5 - 1}");

                foreach (var person in group)
                {
                    Console.WriteLine($"- {person.Name} (age: {person.Age})");
                }
            }
        }
    }
}
