using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Bridge
{
    public class KeyBoard : Product
    {
        public KeyBoard(IBrand brand) : base(brand) { }

        public override string ShowMyself()
        {
            return $"{base._brand.GetBrandName()}的键盘";
        }
    }
}
