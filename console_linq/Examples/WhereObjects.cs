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
            var people = new List<Person>() { 
                new Person { Name = "Randall" , Age = 70, dateAdmissionCompany = new DateTime(2022, 5, 2), Single = true},
                new Person { Name = "Fernanda" , Age = 20, dateAdmissionCompany = new DateTime(2022, 1, 31), Single = false},
                new Person { Name = "Angie" , Age = 15, dateAdmissionCompany = new DateTime(2020, 12, 20), Single = true},
                new Person { Name = "Roger" , Age = 52, dateAdmissionCompany = new DateTime(2005, 05, 15), Single = false},
                new Person { Name = "Teresa" , Age = 94, dateAdmissionCompany = DateTime.Now.AddDays(-1), Single = true}
            };

            var peopleAge25OrYounger = people.Where(p => p.Age <= 25).ToList();

            foreach(var person in peopleAge25OrYounger)
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
