using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_linq.Examples.Miscellaneous
{
    public static class ConcatMiscellaneous
    {
        public static void Main()
        {
            int[] ANumbers = { 1, 2, 3, 4, 5, 6 };
            int[] BNumbers = { 7, 8, 9 };

            var concatNumbers = ANumbers.Concat(BNumbers);

            foreach(int number in concatNumbers) Console.Write(number+" ");
        }
    }
}
