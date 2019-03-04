using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Command
{
    /// <summary>
    /// 命令的接收者
    /// </summary>
    public class Television
    {
        public void Open()
        {
            Console.WriteLine("打开电视机");
        }

        public void Close()
        {
            Console.WriteLine("关闭电视机");
        }
    }
}
