using console_linq.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_linq.Examples.Quantifiers
{
    public static class AllQuantifier
    {
        public static void Main()
        {
            var people = new People().peopleList;

            var getAllAdults = people.All(p => p.Age >= 18);
            Console.WriteLine($"Are they all adults? {getAllAdults}");
        }
    }
}
