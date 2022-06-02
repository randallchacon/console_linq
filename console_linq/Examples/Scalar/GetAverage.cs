using console_linq.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_linq.Examples.Scalar
{
    public static class GetAverage
    {
        public static void Main()
        {
            var numbers = Enumerable.Range(0, 100);

            Console.WriteLine($"The numbers average is: {numbers.Average()}");

            var people = new People().peopleList;

            Console.WriteLine($"The age average is: {people.Average(p => p.Age)}");
        }
    }
}
