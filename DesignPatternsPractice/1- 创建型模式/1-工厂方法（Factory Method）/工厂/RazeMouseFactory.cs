using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.FactoryMethod.Factory
{
    public class RazeMouseFactory : IMouseFactory
    {
        public IMouse CreateMouse()
        {
            return new RazeMouse();
        }
    }
}
