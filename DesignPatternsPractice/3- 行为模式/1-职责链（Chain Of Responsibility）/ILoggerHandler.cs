using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.ChainOfResponsibility
{
    public interface ILoggerHandler
    {
        ILoggerHandler Successor { set; get; }
        void Record(string message, LogLevelEmun logLevel);
    }
}
