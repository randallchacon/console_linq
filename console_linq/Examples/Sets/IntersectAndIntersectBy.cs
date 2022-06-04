using console_linq.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_linq.Examples.Sets
{
    public static class IntersectAndIntersectBy
    {
        public static void Main()
        {
            int[] ANumbers = { 1, 2, 3, 4, 5, 6, 7 };
            int[] BNumbers = { 1, 2, 3, 4, 10, 11, 12 };

            var exceptNumbers = ANumbers.Except(BNumbers);

            foreach (int i in exceptNumbers) Console.Write($"{i} ");

            var APeople = new List<Person>() {
                new Person() { Name = "Randall", CompanyId = 1},
                new Person() { Name = "Sofia", CompanyId = 2},
                new Person() { Name = "Carlos", CompanyId = 1},
                new Person() { Name = "Miguel"},
            };

            var BPeople = new List<Person>() {
                new Person() { Name = "Fabiola", CompanyId = 2},
                new Person() { Name = "Carlos", CompanyId = 1},
                new Person() { Name = "Randall"},
            };

            var ANumbersInAandB = ANumbers.Intersect(BNumbers);

            foreach(var n in ANumbersInAandB) Console.Write($"{n} ");

            Console.WriteLine("----------------");

            var BPeopleNames = BPeople.Select(x => x.Name);
            var peopleInAandBList = APeople.IntersectBy(BPeopleNames, a => a.Name);
            foreach (var p in peopleInAandBList) Console.WriteLine($"{p.Name}");
        }
    }
}
