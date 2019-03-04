using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice
{
    [Serializable]
    public class LogitechKeyboard : IKeyBoard
    {
        public string GetBrand()
        {
            return "罗技-Logitech  G910 RGB";
        }
    }
}
