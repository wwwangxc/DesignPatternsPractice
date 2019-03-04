using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.OBServer
{
    public interface IFans
    {
        Star Idol { set; get; }
        void CheckWeibo();
    }
}
