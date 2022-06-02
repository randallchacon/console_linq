using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_linq.Examples.Pagination
{
    public static class TakeAndTakeLast
    {
        public static void Main() {

            var numbers = Enumerable.Range(1, 100);

            var take10Numbers = numbers.Take(10).ToList();
            var takeLast10Numbers = numbers.TakeLast(10).ToList();

            //Query syntax
            var first10Numbers = (from n in numbers                                  
                                 select n).Take(10);
        }
    }
}
