using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_linq.Examples
{
    public static class DeferredExecution
    {
        public static void main() { 
            int[] numbers = Enumerable.Range(1, 5).ToArray();
            
            var evenNumbers = numbers.Where(n => { //The Where in LINQ is evaluated only if needed, that means deferred execution
                Console.WriteLine($"Evaluating if {n} is even");
                return n % 2 == 0;
            });

            /*
            var evenNumbers = numbers.Where(n => {
                Console.WriteLine($"Evaluating if {n} is even");
                return n % 2 == 0;
            }).ToList();//ToList force to be executed at once
            */ //uncomment to try

            foreach (var number in evenNumbers) {
                Console.WriteLine($"Yes, {number} is even.");
            }
            Console.WriteLine("End");
        }
    }
}
