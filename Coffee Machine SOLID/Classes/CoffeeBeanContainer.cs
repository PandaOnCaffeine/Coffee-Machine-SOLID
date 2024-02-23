using System;
using Coffee_Machine_SOLID.AbstractClasses;

namespace Coffee_Machine_SOLID.Classes
{
    internal class CoffeeBeanContainer : Container
    {
        private int _beanAmout = 0;
        public int BeanAmount
        {
            get { return _beanAmout; }
            set { _beanAmout = value; }
        }

        public CoffeeBeanContainer() { }

        public override void Refill(int amount)
        {
            _beanAmout += amount;
        }
    }
}
