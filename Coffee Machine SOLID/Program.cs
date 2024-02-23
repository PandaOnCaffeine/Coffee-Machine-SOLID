using Coffee_Machine_SOLID.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Machine_SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CoffeeMachine coffeeMaker = new CoffeeMachine();
            WriteMenu();
            while (true)
            {
                ConsoleKey clicked = Console.ReadKey().Key;
                switch (clicked)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        coffeeMaker.Start();
                        break;
                    case ConsoleKey.D2:
                        coffeeMaker.On();
                        WipeThenWrite("Turned On");
                        break;
                    case ConsoleKey.D3:
                        coffeeMaker.AddNewFilter();
                        WipeThenWrite("Filter Added");
                        break;
                    case ConsoleKey.D4:
                        coffeeMaker.AddWater();
                        WipeThenWrite("Water Added");
                        break;
                    case ConsoleKey.D5:
                        coffeeMaker.AddPowder();
                        WipeThenWrite("Beans Added");
                        break;
                    default:
                        WipeThenWrite("Not A Valid Input");
                        break;
                }
                WriteMenu();
            }

        }

        static void WriteMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("1. Start CoffeeMaker");
            Console.WriteLine("2. Turn On CoffeeMaker");
            Console.WriteLine("3. Add Filter CoffeeMaker");
            Console.WriteLine("4. Add Water To CoffeeMaker");
            Console.WriteLine("5. Add Powder To CoffeeMaker");
        }

        static void WipeThenWrite(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
        }
    }
}
