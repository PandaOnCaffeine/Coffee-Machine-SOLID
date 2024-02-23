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
                        Console.WriteLine("How Many Coffee cups worth of Water do you want add?");
                        int water = Convert.ToInt32(Console.ReadLine());
                        coffeeMaker.AddWater(water);
                        WipeThenWrite("Water Added");
                        break;
                    case ConsoleKey.D4:
                        Console.WriteLine("How Many Coffee cups worth of Coffee Beans do you want add?");
                        int beans = Convert.ToInt32(Console.ReadLine());
                        coffeeMaker.AddBeans(beans);
                        WipeThenWrite("Beans Added");
                        break;
                    case ConsoleKey.D5:
                        coffeeMaker.AddNewFilter();
                        WipeThenWrite("Filter Added");
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
            Console.WriteLine("3. Add Water To CoffeeMaker");
            Console.WriteLine("4. Add Coffee Beans To CoffeeMaker");
            Console.WriteLine("5. Add Filter CoffeeMaker");
        }

        static void WipeThenWrite(string message) 
        {
            Console.Clear();
            Console.WriteLine(message);
        }
    }
}
