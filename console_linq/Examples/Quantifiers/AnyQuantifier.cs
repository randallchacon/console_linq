using console_linq.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_linq.Examples.Quantifiers
{
    public static class AnyQuantifier
    {
        public static void Main() {
            var people = new People().peopleList;

            var minorAgeExists = people.Any(p => p.Age < 18);

            Console.WriteLine("Are there any minors? " + minorAgeExists);

            var MajorThan20 = people.Any(p => p.Age > 20);
            Console.WriteLine($"Is someone over 20? {MajorThan20}");
        }
    }
}
