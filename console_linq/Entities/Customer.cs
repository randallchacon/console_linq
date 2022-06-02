using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_linq.Entities
{
    public class Customer : Person
    {
        public List<string> Phones { get; set; }

        public Customer()
        {
            Name = "";
            Phones = new List<string>();
        }
    }
}
