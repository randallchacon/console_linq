using console_linq.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_linq.Examples.Pagination
{
    public static class SkipAndSkipLast
    {
        public static void Main()
        {
            var numbers = Enumerable.Range(1, 100);

            var takeFirst10Numbers = numbers.Take(10).ToList();
            PrintNumbersCollection.print(takeFirst10Numbers);
            var secondBatchNumbers = numbers.Skip(10).Take(10).ToList();
            PrintNumbersCollection.print(secondBatchNumbers);

            var takeLast10Numbers = numbers.TakeLast(10).ToList();
            PrintNumbersCollection.print(takeLast10Numbers);
            var penultimateBatchNumbers = numbers.SkipLast(10).TakeLast(10).ToList();//skip 91 to 100 and take 81 to 90
            PrintNumbersCollection.print(penultimateBatchNumbers);
        }
    }
}
