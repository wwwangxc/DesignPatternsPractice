using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Proxy
{
    public class DynamicAction
    {
        public List<Action> BeforeActionList { set; get; } = new List<Action>();
        public List<Action> AfterActionList { set; get; } = new List<Action>();
    }
}
