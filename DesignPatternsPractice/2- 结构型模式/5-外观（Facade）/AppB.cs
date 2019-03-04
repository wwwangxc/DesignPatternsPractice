using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Facade
{
    public class AppB
    {
        public void Download()
        {
            Console.WriteLine("寻找appB的下载地址");
            Console.WriteLine("访问appB的下载地址");
            Console.WriteLine("开始下载");
            Console.WriteLine("appB下载完毕");
        }

        public void Install()
        {
            Console.WriteLine("寻找appB的安装文件");
            Console.WriteLine("开始安装");
            Console.WriteLine("appB安装完毕");
        }
    }
}
