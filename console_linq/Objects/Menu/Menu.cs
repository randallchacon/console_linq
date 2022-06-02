using console_linq.Examples;
using console_linq.Examples.Filters;
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
            Console.WriteLine("7- ElementAtAndElementAtOrDefault");
            Console.WriteLine("8- SingleAndSingleOrDefault");
            Console.WriteLine("9- Type filter");
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
                    BasicListAndRange.Main();
                    break;
                case 2:
                    DeferredExecution.Main();
                    break;
                case 3:
                    WhereFunction.Main();    
                    break;
                case 4:
                    WhereObjects.Main();
                    break;
                case 5:
                    FirstAndFirstDefault.Main();
                    break;
                case 6:
                    LastAndLastOrDefault.Main();
                    break;
                case 7:
                    ElementAtAndElementAtOrDefault.Main();
                    break;
                case 8:
                    SingleAndSingleOrDefault.Main();
                    break;
                case 9:
                    TypeFilter.Main();
                    break;
                default:
                    Console.WriteLine("Incorrect option...");
                    break;
            }
        }
    }
}
