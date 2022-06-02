using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_linq.Examples.Pagination
{
    public static class IEnumerableExtensions
    {
        public static IEnumerable<T> Paging<T>(this IEnumerable<T> colection, int page, int batchSize)
        {
            return colection.Skip((page -1 ) * batchSize).Take(batchSize);
        }
    }
    public static class PaginationExample
    {
        public static void Main()
        {
            var numbers = Enumerable.Range(1, 100);

            for (int i=1; i<=10;i++)
            {
                Console.WriteLine($"Page {i}");
                var paging = numbers.Paging(i, 10);
                foreach (var number in paging)
                {
                    Console.WriteLine(number);
                }
            }

        }
    }
}
