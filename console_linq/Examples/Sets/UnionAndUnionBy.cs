using console_linq.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_linq.Examples.Sets
{
    public static class UnionAndUnionBy
    {
        public static void Main() { 
            int[] ANumbers = { 1, 2, 3, 6, 7 };
            int[] BNumbers = { 1, 8, 3, 6, 10 };

            var unionNumbers = ANumbers.Union(BNumbers); //fusion and delete duplicate numbers

            foreach(var n in unionNumbers) Console.Write($"{n} ");

            Console.WriteLine("\n------------------------------");

            var APeople = new List<Person>() {
                new Person() { Name = "Randall", CompanyId = 1},
                new Person() { Name = "Fabiola", CompanyId = 2},
                new Person() { Name = "Carlos", CompanyId = 1},
                new Person() { Name = "Randall"},
            };
            var BPeople = new List<Person>() {
                new Person() { Name = "Jose", CompanyId = 1},
                new Person() { Name = "Keyla", CompanyId = 2},
                new Person() { Name = "Randall"},
            };

            var unionPeople = APeople.UnionBy(BPeople, p => p.Name);

            foreach (var i in unionPeople) Console.WriteLine(i.Name);
        }
    }
}
