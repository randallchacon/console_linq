using console_linq.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_linq.Examples.Order
{
    public static class ReverseOrder
    {
        public static void Main() {

            var numbersReverse = Enumerable.Range(1, 20).Reverse();

            foreach (var number in numbersReverse)
            {
                Console.Write(number + " ");
            }

            var people = new People().peopleList;
            people.Reverse();//doesn't create new list, modifying the original list

            var reversePeople = people.AsEnumerable().Reverse().ToList();

            foreach(var person in reversePeople)
            {
                Console.WriteLine($"Name: {person.Name}");
            }
            
            //Queries Syntax
            var numbersReverse2= from n in Enumerable.Range(1, 20).Reverse()
                           select n;

            foreach (var number in numbersReverse2)
            {
                Console.Write(number + " ");
            }
        }
    }
}
