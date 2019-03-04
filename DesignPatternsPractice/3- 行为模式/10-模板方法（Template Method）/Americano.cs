using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Template
{
    public class Americano : CoffeTemplate
    {
        protected override void IntoContainer()
        {
            Console.WriteLine("装入500ml的杯子");
        }

        protected override void AddLiquid()
        {
            Console.WriteLine("加入烧开的纯净水");
        }
    }
}
