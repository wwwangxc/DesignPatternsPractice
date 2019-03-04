using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice
{
    [Serializable]
    public class RazeKeyboard : IKeyBoard
    {
        public string GetBrand()
        {
            return "雷蛇-Raze  萨诺狼蛛";
        }
    }
}
