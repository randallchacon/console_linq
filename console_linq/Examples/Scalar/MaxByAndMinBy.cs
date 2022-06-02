using console_linq.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_linq.Examples.Scalar
{
    public static class MaxByAndMinBy
    {
        public static void Main()
        {
            var people = new People().peopleList;

            var oldestPerson = people.MaxBy(p =>p.Age);
            var youngerPerson = people.MinBy(p => p.Age);

            Console.WriteLine(oldestPerson.Name);
            Console.WriteLine(youngerPerson.Name);
        }
    }
}
