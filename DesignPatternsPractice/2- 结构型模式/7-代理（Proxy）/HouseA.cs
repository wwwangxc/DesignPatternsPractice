using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Proxy
{
    public class HouseA : ContextBoundObject, IHouse
    {
        public string Name { set; get; } = "房屋A";
        public virtual void Buy()
        {
            Console.WriteLine($"购买{this.Name}");
        }
    }
}
