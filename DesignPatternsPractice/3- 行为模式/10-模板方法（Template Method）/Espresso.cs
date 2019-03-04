using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Template
{
    public class Espresso : CoffeTemplate
    {
        protected override void IntoContainer()
        {
            Console.WriteLine("装入30ml的杯子");
        }
    }
}
