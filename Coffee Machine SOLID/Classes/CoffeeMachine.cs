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
        private int _water = 0;
        private Powder _powder;

        public CoffeeMachine()
        {
            _powder = new CoffeePowder();
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

            if (_water <= 0)
            {
                Console.WriteLine("Not Any Water Left");
                return;
            }

            if (_powder.Amount <= 0)
            {
                Console.WriteLine($"Not Any {_powder.Name} Left");
                return;
            }
            Brew();
        }
        public void Brew()
        {
            int count = 1;
            while (_water >= 1 && _powder.Amount >= 1)
            {
                Console.WriteLine($"Cup nr {count} of coffee");
                Thread.Sleep(400); //Wait time between each cup of coffee
                _water -= 1;
                _powder.Amount -= 1;
                count++;
            }
            Console.WriteLine("Done");
            _filter = false;
        }

        public void AddNewFilter()
        {
            _filter = true;
        }
        public void AddWater()
        {
            Console.WriteLine("How Many Cups worth of Water do you want add?");
            int amount = Convert.ToInt32(Console.ReadLine());
            _water += amount;
        }
        public void AddPowder()
        {
            Console.WriteLine("How Many Cups worth of Powder do you want add?");
            int powderAmount = Convert.ToInt32(Console.ReadLine());
            _powder.Amount += powderAmount;
        }
    }
}
