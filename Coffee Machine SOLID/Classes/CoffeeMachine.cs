using Coffee_Machine_SOLID.AbstractClasses;
using Coffee_Machine_SOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Coffee_Machine_SOLID.Classes
{
    internal class CoffeeMachine : Machine, ICoffeeMachine
    {
        private bool _filter = false;
        private readonly WaterContainer _waterContainer;
        private readonly CoffeeBeanContainer _coffeeBeanContainer;
        public CoffeeMachine()
        {
            _waterContainer = new WaterContainer();
            _coffeeBeanContainer = new CoffeeBeanContainer();
        }
        public override void Start()
        {
            if (!_isOn)
            {
                Console.WriteLine("Coffee Machine Not Turn On");
                return;
            }

            if (!_filter)
            {
                Console.WriteLine("No Filter");
                return;
            }

            if (_waterContainer.WaterAmount <= 0)
            {
                Console.WriteLine("Not Any Water Left");
                return;
            }

            if (_coffeeBeanContainer.BeanAmount <= 0)
            {
                Console.WriteLine("Not Any Coffee Beans Left");
                return;
            }

            int count = 0;
            while (_waterContainer.WaterAmount >= 1 && _coffeeBeanContainer.BeanAmount >= 1)
            {
                count++;
                Console.WriteLine($"Cup nr {count} of coffee");
                Thread.Sleep(400); //Wait time between each cup of coffee
                _waterContainer.WaterAmount -= 1;
                _coffeeBeanContainer.BeanAmount -= 1;
            }
            Console.WriteLine("Done");
            _filter = false;
        }

        public void AddNewFilter()
        {
            _filter = true;
        }
        public void AddWater(int amount)
        {
            _waterContainer.Refill(amount);
        }
        public void AddBeans(int amount)
        {
            _coffeeBeanContainer.Refill(amount);
        }
    }
}
