using console_linq.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_linq.Examples.Scalar
{
    public static class CountAndLongCount
    {
        public static void Main() {

            var people = new People().peopleList;

            Console.WriteLine($"Total people: " + people.Count());
            
            Console.WriteLine("----------------\n");
            Console.WriteLine($"Quantity of single people: { people.Count(p => p.Single)}");

            Console.WriteLine($"int max = {int.MaxValue.ToString("N")}"); //if the value is major than this, we need to use longCount

            //people.LongCount();

            //Query syntax
            var SingleCount = (from p in people
                              where p.Single
                              select p).Count();

            bool end = true;
        }
    }
}
