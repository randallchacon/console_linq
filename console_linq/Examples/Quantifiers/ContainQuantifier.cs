using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_linq.Examples.Quantifiers
{
    public static class ContainQuantifier
    {
        public static void Main()
        {
            var numbers = Enumerable.Range(1, 5);

            Console.WriteLine($"¿Does the list contain the number 3? {numbers.Contains(3)}");
            Console.WriteLine($"¿Does the list contain the number 10? {numbers.Contains(10)}");
        }
    }
}
