using console_linq.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_linq.Examples.Scalar
{
    public static class SumMaxMin
    {
        public static void Main()
        {
            var numbers = Enumerable.Range(1, 5);

            var sumNumbers = numbers.Sum();
            Console.WriteLine(sumNumbers.ToString());

            var people = new People().peopleList;

            Console.WriteLine($"The sum of ages is: {people.Sum(p => p.Age)}" );
            Console.WriteLine($"The max age is: {people.Max(p => p.Age)}");
            Console.WriteLine($"The min age is: {people.Min(p => p.Age)}");
        }
    }
}
