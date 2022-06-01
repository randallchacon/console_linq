using console_linq.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_linq.Examples
{
    public static class SingleAndSingleOrDefault
    {
        public static void main() {
            var people = new People().peopleList;

            var personOver90YearOld = people.Single(p => p.Age > 90);

            Console.WriteLine($"Person over 90 years old: {personOver90YearOld.Name}");

            var personYoungerOrEqualsTo10YearsOlds = (from p in people
                                                     where p.Age <= 10 
                                                     select p).SingleOrDefault();
            Console.WriteLine("----------------\n");
            Console.WriteLine($"Person with 10 years old or younger: {personYoungerOrEqualsTo10YearsOlds.Name}");
            
            Console.WriteLine("----------------\n");
            try
            {
                var personYoungerThan5YearsOld = people.SingleOrDefault(p => p.Age < 5);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: not results");
            }

            try
            {
                var personOver20YearsOld = people.SingleOrDefault(p => p.Age > 20);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: too many results");
            }


        }
    }
}
