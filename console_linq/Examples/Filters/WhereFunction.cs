using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_linq.Examples
{
    public static class WhereFunction
    {
        public static void Main() { 
            int[] numbers = Enumerable.Range(0, 20).ToArray();
            var oddNumbers = numbers.Where(x => x % 2 == 1).ToList();

            Console.WriteLine("The odd numbers are: ");
            foreach (var number in oddNumbers)
            {
                Console.WriteLine(number);
            }

            //Methods syntax or Lambda syntax
            var oddNumbersGreaterThan10 = numbers.Where(n => n % 2 == 1 && n > 10).ToList();

            Console.WriteLine("The odd numbers greater than 10 are: ");
            foreach (var number in oddNumbersGreaterThan10)
            {
                Console.WriteLine(number);
            }

            //Queries Syntax
            var oddNumbersGreaterThanTen = from n in numbers
                                           where n % 2 == 1 && n > 10
                                           select n;

            Console.WriteLine("The odd numbers greater than 10 are: ");
            foreach (var number in oddNumbersGreaterThanTen)
            {
                Console.WriteLine(number);
            }
        }
    }
}
