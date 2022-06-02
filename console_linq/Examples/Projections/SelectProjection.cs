using console_linq.DTOs;
using console_linq.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_linq.Examples.Projections
{
    public static class SelectProjection
    {
        public static void main() {
            var people = new People().peopleList;

            var names = people.Select(p => p.Name).ToList();

            foreach (var name in names) { 
                Console.WriteLine(name);
            }

            Console.WriteLine("----------------\n");
            var namesAndAges = people.Select(p => new {p.Name, p.Age}).ToList();
            foreach (var person in namesAndAges) { 
                Console.WriteLine(person.Name + " " + person.Age);
            }

            Console.WriteLine("----------------\n");
            var namesAndAgesDTO = people.Select(p => new PersonDTO {Name = p.Name, Age = p.Age}).ToList();
            foreach (var person in namesAndAgesDTO)
            {
                Console.WriteLine(person.Name + " " + person.Age);
            }

            var numbers = Enumerable.Range(1, 5).ToList();
            var duplicateNumbers = numbers.Select(n => n * 2).ToList();

            Console.WriteLine("----------------\n");
            foreach (var n in duplicateNumbers)
            {
                Console.WriteLine($"{n}");
            }

            Console.WriteLine("----------------\n");
            var peopleWithIndex = people.Select((p, index) => new { person = p, indexPerson = index + 1 }); //it isn't possible to do it by query syntax
            foreach (var p in peopleWithIndex)
            {
                Console.WriteLine($"{p.indexPerson} - {p.person.Name}");
            }

            //Queries Syntax
            var names_2 = (from p in people
                           select p.Name).ToList();

            var namesAndAges_2 = (from p in people
                                  select new { name = p.Name, age = p.Age });

            var duplicateNumbers_2 = from n in numbers
                                  select 2 * n;
        }
    }
}
