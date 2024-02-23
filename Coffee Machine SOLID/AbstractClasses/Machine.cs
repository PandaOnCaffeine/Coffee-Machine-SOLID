using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Machine_SOLID.AbstractClasses
{
    internal abstract class Machine
    {
        protected bool _isOn = false;
        public virtual void On()
        {
            _isOn = true;
        }
        public virtual void Off()
        {
            _isOn = false;
        }
    }
}
