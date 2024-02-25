using Coffee_Machine_SOLID.AbstractClasses;
using Coffee_Machine_SOLID.Classes;
using System;

namespace Coffee_Machine_SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CoffeeMachine coffeeMaker = new CoffeeMachine();

            // Make coffee
            coffeeMaker.AddWater(2); // Add water for 2 cups of coffe
            Beverage coffee = new Coffee(2);
            coffeeMaker.Brew(coffee); // Brew coffee

            // Make tea
            coffeeMaker.AddWater(1); // Add water for 1 cups of tea
            Beverage tea = new Tea(1);
            coffeeMaker.Brew(tea); // Brew coffee

            Console.ReadLine();
        }
    }
}
