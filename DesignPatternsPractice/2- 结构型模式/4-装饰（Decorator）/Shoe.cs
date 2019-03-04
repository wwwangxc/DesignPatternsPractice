using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Decorator
{
    public class Shoe : Decorator
    {
        public Shoe(Component component) : base(component) { }

        public override string ShowMyself()
        {
            return base.ShowMyself() + Environment.NewLine + "我穿了一双棕色的登山鞋";
        }
    }
}
