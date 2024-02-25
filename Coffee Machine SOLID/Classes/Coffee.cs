using Coffee_Machine_SOLID.AbstractClasses;
using System;

namespace Coffee_Machine_SOLID.Classes
{
    internal class Coffee : Beverage
    {
        public Coffee(int cups) : base(cups)
        {
        }

        public override void AddIngredients()
        {
            Console.WriteLine("Added coffee beans to the machine.");
        }

        public override void Brew()
        {
            Console.WriteLine("Brewing coffee...");
            Console.WriteLine("Your coffee is ready!");
        }
    }
}
