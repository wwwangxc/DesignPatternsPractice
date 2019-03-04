using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.FactoryMethod.Factory
{
    public class LogitechMouseFactory : IMouseFactory
    {
        public IMouse CreateMouse()
        {
            return new LogitechMouse();
        }
    }
}
