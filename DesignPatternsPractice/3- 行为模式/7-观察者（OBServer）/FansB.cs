using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.OBServer
{
    public class FansB : IFans
    {
        public FansB(Star star)
        {
            star.FansList.Add(this);
            this.Idol = star;
        }

        public Star Idol { get; set; }

        public void CheckWeibo()
        {
            Console.WriteLine($"[FansB]: 查看明星Star发布的微博 - {this.Idol.Msg}");
        }
    }
}
