using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_linq.Entities
{
    [DebuggerDisplay("{Nombre}")]
    public class Person
    {
    public string Name { get; set; }
    public int Age { get; set; }
    public bool Single { get; set; }
    public DateTime dateAdmissionCompany { get; set; }
    public List<string> Phones = new List<string>();
    public int CompanyId { get; set; }
}
}
