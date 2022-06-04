using console_linq.Collections;
using console_linq.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_linq.Examples.Miscellaneous
{
    public static class TryGetNonEnumaratedCountMiscellaneous
    {
        public static void Main()
        {
            int[] ANumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var counter = 0;

            var counterWithoutEnumerator = ANumbers.TryGetNonEnumeratedCount(out counter);

            Console.WriteLine(counterWithoutEnumerator);

            var APeople = new List<Person>()
            {
                new Person() { Name = "Randall", CompanyId = 1},
                new Person() { Name = "Sofia", CompanyId = 2},
                new Person() { Name = "Carlos", CompanyId = 1},
                new Person() { Name = "Miguel"},
            };

            var peopleColletion = new PeopleCollection();
            peopleColletion.AddRange(APeople);

            var peopleCounter = peopleColletion.Count();

            Console.WriteLine($"Quantity of people: {peopleCounter}");

            var tryCountPeopleCollection = peopleColletion.TryGetNonEnumeratedCount(out peopleCounter);//False without performing an enumeration

            Console.WriteLine($"Try count people collection: {tryCountPeopleCollection}");
        }
    }
}
