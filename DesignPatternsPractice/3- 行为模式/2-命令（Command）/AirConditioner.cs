using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Command
{
    /// <summary>
    /// 命令接收者
    /// </summary>
    public class AirConditioner
    {
        public void Open()
        {
            Console.WriteLine("打开空调");
        }

        public void Close()
        {
            Console.WriteLine("关闭空调");
        }
    }
}
