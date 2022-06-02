using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_linq.Examples.Scalar
{
    public static class AggregateFunction
    {
        public static void Main()
        {
            var numbers = Enumerable.Range(1, 5);
            var result = numbers.Aggregate((x, y) => x*y); //1*2*3*4*5

            Console.WriteLine("The result is: " + result);

            //seed
            var resultWithInitialValue = numbers.Aggregate(10, (a, b) => a * b);
            Console.WriteLine($"The final result with value seed is: {resultWithInitialValue}");
        }
    }
}
