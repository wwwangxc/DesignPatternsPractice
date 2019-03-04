using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Facade
{
    public class AppA
    {
        public void Download()
        {
            Console.WriteLine("寻找appA的下载地址");
            Console.WriteLine("访问appA的下载地址");
            Console.WriteLine("开始下载");
            Console.WriteLine("appA下载完毕");
        }

        public void Install()
        {
            Console.WriteLine("寻找appA的安装文件");
            Console.WriteLine("开始安装");
            Console.WriteLine("appA安装完毕");
        }
    }
}
