using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Decorator
{
    public class Trouser : Decorator
    {
        public Trouser (Component component) : base(component) { }

        public override string ShowMyself()
        {
            return base.ShowMyself() + Environment.NewLine + "我穿了一件蓝色的牛仔裤";
        }
    }
}
