using Coffee_Machine_SOLID.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Machine_SOLID.Classes
{
    internal class CoffeePowder : Powder
    {
        public CoffeePowder() : base()
        {
            _amount = 0;
            _name = "Coffee Powder";
            _endProduct = "Coffee";
        }
    }
}
