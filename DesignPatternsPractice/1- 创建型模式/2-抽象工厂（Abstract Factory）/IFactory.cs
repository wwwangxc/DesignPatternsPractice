using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.AbstractFactory
{
    public interface IFactory
    {
        IMouse CreateMouse();
        IKeyBoard CreateKeyboard();
    }
}
