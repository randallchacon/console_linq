using console_linq.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_linq.Examples
{
    public static class ElementAtAndElementAtOrDefault
    {
        public static void main() {
            var people = new People().peopleList;

            var thirdPerson = people.ElementAt(2);
            Console.WriteLine($"Third person: {thirdPerson.Name}");

            var fourthPerson = people.ElementAtOrDefault(3);
            Console.Write("----------------\n");
            Console.WriteLine($"Fourth person: {fourthPerson.Name}");

            //Queries syntax
            var sixthPerson = (from p in people
                               select p).ElementAtOrDefault(5);
            Console.Write("----------------\n");
            Console.WriteLine($"Sixth person: {sixthPerson.Name}");
        }
    }
}
