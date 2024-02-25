using Coffee_Machine_SOLID.AbstractClasses;
using System;

namespace Coffee_Machine_SOLID.Classes
{
    internal class CoffeeMachine
    {
        private int _water;
        public CoffeeMachine()
        {
            _water = 0;
        }
        public void AddWater(int amount)
        {
            _water += amount;
            Console.WriteLine($"Added {amount} cups of water to the machine.");
        }

        public void AddNewFilter()
        {
            Console.WriteLine($"Added a filter to the machine.");

        }

        public void Brew(Beverage beverage)
        {
            if (_water >= beverage.Amount)
            {
                beverage.AddIngredients();
                beverage.Brew();
                _water -= beverage.Amount;
            }
            else
            {
                Console.WriteLine("Not enough water to brew. Please add water.");
            }
        }
    }
}
