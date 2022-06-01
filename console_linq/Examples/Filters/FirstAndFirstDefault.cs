using console_linq.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_linq.Examples
{
    public static class FirstAndFirstDefault
    {
        public static void main() {
            var people = new People();

            var firstPerson = people.peopleList.First();
            var firstOrDefaultPerson = people.peopleList.FirstOrDefault();

            Console.WriteLine($"{firstPerson.Name}"); //might throw an error if the value is empty

            Console.Write("----------------\n");
            Console.WriteLine($"{firstOrDefaultPerson.Name}"); //if it's empty, returns default value. Null

            var numbers = new List<int>();
            var firstNumber = numbers.FirstOrDefault();//0

            Console.Write("----------------\n");
            Console.WriteLine($"First number: {firstNumber}");

            //Methods syntax
            var firstNotSinglePerson = people.peopleList.FirstOrDefault(p => !p.Single);

            //Queries syntax
            var firstNotSinglePerson_2 = (from p in people.peopleList
                                         where !p.Single
                                         select p).FirstOrDefault();

            Console.Write("----------------\n");
            Console.WriteLine($"First single person: {firstNotSinglePerson.Name}");

            Console.Write("----------------\n");
            Console.WriteLine($"First single person: {firstNotSinglePerson_2.Name}");
        }
    }
}
