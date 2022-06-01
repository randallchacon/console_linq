using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_linq.Examples
{
    public static class BasicListAndRange
    {
        static int[] numbers = { 1, 2, 3, 4, 5 };
        static int[] numbersRange = Enumerable.Range(1, 20).ToArray();

        public static void main() {
            //Methods Syntax or Lambda Sintax
            var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

            //Queries syntax
            var evenNumbers2 = from n in numbers
                               where n % 2 == 0
                               select n;

            //Range
            var evenRangeNumbers = numbersRange.Where(n => n % 2 == 0).ToList();

            Console.WriteLine("End");
        }
    }
}
