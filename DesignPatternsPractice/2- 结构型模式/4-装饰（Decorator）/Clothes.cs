using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Decorator
{
    public class Clothes : Decorator
    {
        public Clothes(Component component) : base(component) { }

        public override string ShowMyself()
        {
            return base.ShowMyself() + Environment.NewLine + "我穿了一件红色的格子衬衫";
        }
    }
}
