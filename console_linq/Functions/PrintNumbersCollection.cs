using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_linq.Functions
{
    public static class PrintNumbersCollection
    {
        public static void print(List<int> numbers, string msg = "")
        {
            Console.Write($"{msg}");
            foreach (var number in numbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine("\n-------------");
        }
    }
}
