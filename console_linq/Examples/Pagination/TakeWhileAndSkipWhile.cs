using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using console_linq.Functions;

namespace console_linq.Examples.Pagination
{
    public static class TakeWhileAndSkipWhile
    {
        public static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 3, 2, 1 };

            //as long as the predicate is false, it should ignore the rest of the collection
            var resultTakeWhile = numbers.TakeWhile(x => x < 5).ToList();
            PrintNumbersCollection.print(resultTakeWhile, "Take while numbers: ");

            //Skip the elements while the predicate is true
            var resultSkipWhile = numbers.SkipWhile(x => x < 5).ToList();
            PrintNumbersCollection.print(resultSkipWhile, "Skip while numbers: ");

        }
    }
}
