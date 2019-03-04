using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Proxy
{
    public class HouseProxy : IHouse
    {
        private IHouse _House = null;

        public HouseProxy(IHouse house)
        {
            this._House = house;
        } 

        public void Buy()
        {
            Console.WriteLine("收取中介费");
            Console.WriteLine("办理各种过户手续");
            this._House.Buy();
            Console.WriteLine("交易完成");
        }
    }
}
