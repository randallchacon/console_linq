using console_linq.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_linq.Examples
{
    public static class LastAndLastOrDefault
    {
        public static void Main() {
            var people = new People();

            var lastPerson = people.peopleList.Last();
            var lastOrDefaultPerson = people.peopleList.LastOrDefault();
            var lastSinglePerson = people.peopleList.Last(p => p.Single);

            Console.WriteLine($"Last person: {lastPerson.Name}");

            Console.Write("----------------\n");
            Console.WriteLine($"Last or default person: {lastOrDefaultPerson.Name}");

            Console.Write("----------------\n");
            Console.WriteLine($"Last single person: {lastSinglePerson.Name}");

            //Queries Syntax
            var lastSinglePerson_2 = (from p in people.peopleList
                                      where p.Single
                                      select p).Last();

            Console.Write("----------------\n");
            Console.WriteLine($"Last single person: {lastSinglePerson_2.Name}");
        }
    }
}
