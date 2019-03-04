using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.AbstractFactory
{
    public class RazeFactory : IFactory
    {
        public IKeyBoard CreateKeyboard()
        {
            return new RazeKeyboard();
        }

        public IMouse CreateMouse()
        {
            return new RazeMouse();
        }
    }
}
