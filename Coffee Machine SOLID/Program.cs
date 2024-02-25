using Coffee_Machine_SOLID.AbstractClasses;
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

            // Make coffee
            coffeeMaker.AddWater(2); // Add water for 2 cups
            Beverage coffee = new Coffee(2);
            coffeeMaker.Brew(coffee); // Brew coffee


            Console.ReadLine();
        }
    }
}
