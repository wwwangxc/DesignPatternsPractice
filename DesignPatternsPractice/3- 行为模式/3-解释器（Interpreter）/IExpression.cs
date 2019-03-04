using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Interpreter
{
    /// <summary>
    /// 抽象表达式接口
    /// </summary>
    public interface IExpression
    {
        double Interpret();
    }
}
