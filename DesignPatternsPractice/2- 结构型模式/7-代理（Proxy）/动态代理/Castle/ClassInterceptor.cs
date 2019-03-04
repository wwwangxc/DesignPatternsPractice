using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Proxy
{
    public class ClassInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine("收取中介费");
            Console.WriteLine("办理各种过户手续");
            invocation.Proceed();
            Console.WriteLine("交易完成");
        }
    }
}
