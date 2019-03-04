using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.ChainOfResponsibility
{
    public class ErrorLogger : ILoggerHandler
    {
        public ILoggerHandler Successor { get; set; } = null;

        public void Record(string message, LogLevelEmun logLevel)
        {
            if (logLevel == LogLevelEmun.ERROR)
            {
                Console.WriteLine(this.GetType().Name);
                Console.WriteLine($"记录日志[ERROR]：{message}");
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
