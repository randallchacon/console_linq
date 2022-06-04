using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_linq.Examples.Miscellaneous
{
    public static class SequenceEqualsMiscellaneous
    {
        public static void Main()
        {
            string[] A = { "Randall", "Chacón" };
            string[] B = { "Randall", "Chacón" };
            string[] C = { "RaNdaLl", "ChACón" };
            string[] D = { "Chacón", "Randall" };

            var AB = A.SequenceEqual(B);            
            var AC = A.SequenceEqual(C);
            var AD = A.SequenceEqual(D);
            var ACIgnoreCapitalLetters = A.SequenceEqual(C, StringComparer.OrdinalIgnoreCase);

            Console.WriteLine(AB);//TRUE
            Console.WriteLine(AC);//FALSE
            Console.WriteLine(AD);//FALSE
            Console.WriteLine(ACIgnoreCapitalLetters);//TRUE
        }
    }
}
