using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Decorator
{
    public class Human : Component
    {
        public string ShowMyself()
        {
            return "我叫程序员";
        }
    }
}
