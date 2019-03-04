using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Proxy
{
    public class ProxyFactory<T> where T : ContextBoundObject
    {
        public T CreateProxy(DynamicAction action = null)
        {
            return (T)new DynamicProxy<T>(action).GetTransparentProxy();
        }

        public T CreateProxy(T obj, DynamicAction action = null)
        {
            return (T)new DynamicProxy<T>(obj, action).GetTransparentProxy();
        }
    }
}
