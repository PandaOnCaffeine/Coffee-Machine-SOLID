using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Machine_SOLID.AbstractClasses
{
    internal abstract class Powder
    {
        protected int _amount;
        protected string _name;
        protected string _endProduct;
        public int Amount { get { return _amount; } set { _amount = value; } }
        public string Name { get { return _name; } }
        public string EndProduct { get { return _endProduct; } }
    }
}
