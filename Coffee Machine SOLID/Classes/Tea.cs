using Coffee_Machine_SOLID.AbstractClasses;
using System;

namespace Coffee_Machine_SOLID.Classes
{
    internal class Tea : Beverage
    {
        public Tea(int cups) : base(cups)
        {

        }

        public override void AddIngredients()
        {
            Console.WriteLine("Added tea leaves to the machine.");
        }

        public override void Brew()
        {
            Console.WriteLine("Brewing tea...");
            Console.WriteLine("Your tea is ready!");
        }
    }
}
