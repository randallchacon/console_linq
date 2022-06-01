using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_linq.Entities
{
    public class People
    {
        public List<Person> peopleList { get; set; }

        public People()
        {
            peopleList = new List<Person>() {
                new Person { Name = "Randall" , Age = 70, dateAdmissionCompany = new DateTime(2022, 5, 2), Single = true},
                new Person { Name = "Fernanda" , Age = 20, dateAdmissionCompany = new DateTime(2022, 1, 31), Single = false},
                new Person { Name = "Angie" , Age = 15, dateAdmissionCompany = new DateTime(2020, 12, 20), Single = true},
                new Person { Name = "Roger" , Age = 52, dateAdmissionCompany = new DateTime(2005, 05, 15), Single = false},
                new Person { Name = "Teresa" , Age = 94, dateAdmissionCompany = DateTime.Now.AddDays(-1), Single = false},
                new Person { Name = "María" , Age = 10, dateAdmissionCompany = DateTime.Now.AddMonths(-2), Single = true}
            };
        }
    }
}
