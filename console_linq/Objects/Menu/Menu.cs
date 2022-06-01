using console_linq.Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_linq.Objects.Menu
{
    public static class Menu
    {
        public static void show()
        {
            Console.WriteLine("1- Basic List and Range");
            Console.WriteLine("2- DeferredExecution");
            Console.WriteLine("3- WhereFunction");
            Console.WriteLine("4- WhereObjects");
            Console.WriteLine("5- FirstAndFirstDefault");
            Console.WriteLine("6- LastAndLastOrDefault");
            Console.Write("Choose an option: ");
            
            int numberOption = 0;
            var input = Console.ReadLine();

            Console.WriteLine("\n");

            bool success = int.TryParse(input, out numberOption);

            if (success)
                numberOption = int.Parse(input);

            switch (numberOption)
            {
                case 1:
                    BasicListAndRange.main();
                    break;
                case 2:
                    DeferredExecution.main();
                    break;
                case 3:
                    WhereFunction.main();    
                    break;
                case 4:
                    WhereObjects.main();
                    break;
                case 5:
                    FirstAndFirstDefault.main();
                    break;
                case 6:
                    LastAndLastOrDefault.main();
                    break;
                default:
                    Console.WriteLine("Incorrect option...");
                    break;
            }
        }
    }
}
