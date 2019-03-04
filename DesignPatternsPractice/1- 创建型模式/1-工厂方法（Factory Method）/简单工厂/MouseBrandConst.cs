using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.FactoryMethod.SimpleFactory
{
    /// <summary>
    /// 鼠标常数,维护鼠标类的完全限定名
    /// </summary>
    public class MouseBrandConst
    {
        public static readonly string Logitech = typeof(LogitechMouse).FullName;
        public static readonly string Raze = typeof(RazeMouse).FullName;
    }
}
