using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice
{
    [Serializable]
    public class RazeMouse : IMouse
    {
        public string GetBrand()
        {
            return "雷蛇-Raze  蝰蛇";
        }
    }
}
