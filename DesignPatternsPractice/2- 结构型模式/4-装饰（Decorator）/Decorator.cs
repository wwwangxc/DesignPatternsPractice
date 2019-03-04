using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Decorator
{
    public abstract class Decorator : Component
    {
        protected Component _component = null;
        public Decorator(Component component)
        {
            this._component = component;
        }
        public virtual string ShowMyself()
        {
            return this._component.ShowMyself();
        }
    }
}
