using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.OBServer
{
    public class Star
    {
        public List<IFans> FansList { set; get; } = new List<IFans>();

        public string Msg { set; get; } = string.Empty;

        public void CreateWeibo()
        {
            this.Msg = "今天天气不错！";
            Console.WriteLine($"[Star]：发布了一条微博 - {this.Msg}");
            this.Notify();
        }

        public void Notify()
        {
            Console.WriteLine("[Star]：向我的粉丝发送通知");

            foreach (var fans in FansList)
            {
                fans.CheckWeibo();
            }
        }
    }
}
