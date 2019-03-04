using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.AbstractFactory
{
    public class LogitechFactory : IFactory
    {
        public IKeyBoard CreateKeyboard()
        {
            return new LogitechKeyboard();
        }

        public IMouse CreateMouse()
        {
            return new LogitechMouse();
        }
    }
}
