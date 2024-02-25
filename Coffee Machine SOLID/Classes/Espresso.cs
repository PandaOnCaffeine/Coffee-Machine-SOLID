using Coffee_Machine_SOLID.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Machine_SOLID.Classes
{
    internal class Espresso : Beverage
    {
        public Espresso() : base(1) // Espresso allows only one cup
        {

        }

        public override void AddIngredients()
        {
            Console.WriteLine("Added espresso grounds to the machine.");
        }

        public override void Brew()
        {
            Console.WriteLine("Brewing espresso...");
            Console.WriteLine("Your espresso is ready!");
        }
    }
}
