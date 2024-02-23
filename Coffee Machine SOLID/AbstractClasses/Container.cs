using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Machine_SOLID.AbstractClasses
{
    internal abstract class Container
    {
        public abstract void Refill(int amount);
    }
}
