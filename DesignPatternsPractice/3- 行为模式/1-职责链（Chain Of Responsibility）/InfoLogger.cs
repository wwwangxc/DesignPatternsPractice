using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.ChainOfResponsibility
{
    public class InfoLogger : ILoggerHandler
    {
        public ILoggerHandler Successor { get; set; } = null;

        public void Record(string message, LogLevelEmun logLevel)
        {
            if(logLevel == LogLevelEmun.INFO)
            {
                Console.WriteLine(this.GetType().Name);
                Console.WriteLine($"记录日志[INFO]：{message}");
                Console.WriteLine("---------------------------");
            }
            else if (this.Successor != null)
            {
                this.Successor.Record(message, logLevel);
            }
            else
            {
                Console.WriteLine(this.GetType().Name);
                Console.WriteLine($"日志记录失败，不识别的日志类型“{logLevel}”");
                Console.WriteLine("---------------------------");
            }
        }
    }
}
