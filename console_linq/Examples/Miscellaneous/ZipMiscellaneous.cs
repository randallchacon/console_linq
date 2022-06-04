using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_linq.Examples.Miscellaneous
{
    public static class ZipMiscellaneous
    {
        public static void Main()
        {
            //Combine elements
            int[] ANumbers = { 1, 2, 3, 4, 5 };
            int[] BNumbers = { 6, 7, 8, 9, 10 };

            var combineNumbers = ANumbers.Zip(BNumbers);

            foreach (var number in combineNumbers) Console.Write(number+ " ");

            Console.WriteLine("\n---------------");

            var sumCombineNumbers = ANumbers.Zip(BNumbers, (a, b) => a + b);

            foreach (var number in sumCombineNumbers) Console.Write(number + " ");

        }
    }
}
