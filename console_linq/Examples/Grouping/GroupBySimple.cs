using console_linq.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_linq.Examples.Grouping
{
    public static class GroupBySimple
    {
        public static void Main() {

            var people = new People().peopleList;

            var groupBySingleState = people.GroupBy(p => p.Single);

            foreach (var group in groupBySingleState)
            {
                Console.WriteLine($"People group where single = {group.Key} (total: {group.Count()})");
                foreach (var person in group)
                {
                    Console.WriteLine($"- {person.Name}");
                }
            }

            Console.WriteLine("---------------------------");
            //Query syntax
            var groupBySingleState_2 = from p in people
                                       group p by p.Single into groups
                                       select groups;

            foreach (var group in groupBySingleState_2)
            {
                Console.WriteLine($"People group where single = {group.Key} (total: {group.Count()})");
                foreach (var person in group)
                {
                    Console.WriteLine($"- {person.Name}");
                }
            }
        }        
    }
}
