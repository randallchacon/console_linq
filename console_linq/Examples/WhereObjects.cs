using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using console_linq.Entities;

namespace console_linq.Examples
{
    public static class WhereObjects
    {
        public static void main()
        {
            var people = new People().peopleList;

            var peopleAge25OrYounger = people.Where(p => p.Age <= 25).ToList();

            foreach (var person in peopleAge25OrYounger)
            {
                Console.WriteLine($"{person.Name} is {person.Age} years old.");
            }

            Console.Write("----------------\n");
            var singlePeopleYoungerThan25YearsOld = people.Where(p => p.Single && p.Age < 25).ToList();

            foreach(var person in singlePeopleYoungerThan25YearsOld)
            {
                Console.WriteLine($"{ person.Name} is single and younger than 25 years old.");
            }

            //Methods syntax
            var peopleWithLessThan3MonthsInTheCompany = people.
                                                Where(p => p.dateAdmissionCompany >= DateTime.Now.AddMonths(-3)).ToList();

            //Queries syntax
            var peopleWithLessThan3MonthsInTheCompany_2 = from p in people
                                                         where p.dateAdmissionCompany >= DateTime.Now.AddMonths(-3)
                                                         select p;

            Console.Write("----------------\n");
            foreach (var person in peopleWithLessThan3MonthsInTheCompany)
            {
                Console.WriteLine($"{person.Name} has less than three months in the company");
            }

            Console.Write("----------------\n");
            foreach (var person in peopleWithLessThan3MonthsInTheCompany_2)
            {
                Console.WriteLine($"{person.Name} has less than 3 months in the company");
            }
        }
    }
}
