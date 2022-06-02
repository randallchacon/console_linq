using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_linq.Examples.Filters
{
    public static class TypeFilter
    {
        public abstract class Student
        {
            public abstract string? Name { get; set; }
        }

        public class NewStudent : Student
        {
            public override string? Name { get; set; }
        }

        public class RegularStudent : Student
        {
            public override string? Name { get; set; }
        }

        public static void Main()
        {
            var objectList = new List<object>() { "Randall", 5, 2, "María", true };

            var strings = objectList.OfType<string>();
            var numbers = objectList.OfType<int>();

            foreach (var number in numbers)
            {
                Console.WriteLine($"Integers: {number}");
            }

            foreach (var text in strings)
            {
                Console.WriteLine($"Strings: {text}");
            }

            var searchStrings = from s in strings.OfType<string>()
                                select s;

            foreach (var text in searchStrings)
            {
                Console.WriteLine($"Strings: {text}");
            }

            Console.WriteLine("----------------\n");


            Console.WriteLine("End");

            var StudentList = new List<Student>() 
            {
                new NewStudent(){ Name = "Roger"},
                new NewStudent(){ Name = "Carlos"},
                new RegularStudent(){ Name = "Marta"},
                new NewStudent(){ Name = "Enrique"},
                new RegularStudent(){ Name = "Elí"}
            };

            var regularStudents = StudentList.OfType<RegularStudent>();

            foreach (var student in regularStudents)
            {
                Console.WriteLine($"Regular students {student.Name}");
            }
        }
    }
}
