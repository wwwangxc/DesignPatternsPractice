using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Proxy
{
    public class DynamicProxy<T> : RealProxy where T : ContextBoundObject
    {
        private T _target = default(T);
        private DynamicAction _dynamicAction = null;

        public DynamicProxy(DynamicAction action = null) : base(typeof(T))
        {
            this._target = (T)Activator.CreateInstance(typeof(T));
            this._dynamicAction = action;
        }

        public DynamicProxy(T obj, DynamicAction action = null) : base(typeof(T))
        {
            this._target = obj;
            this._dynamicAction = action;
        }

        public override IMessage Invoke(IMessage msg)
        {
            var reqMsg = msg as IMethodCallMessage;
            if (reqMsg == null)
            {
                return new ReturnMessage(new Exception("调用失败"), null);
            }

            if (this._dynamicAction != null
                && this._dynamicAction.BeforeActionList != null
                && this._dynamicAction.BeforeActionList.Count > 0)
            {
                this._dynamicAction.BeforeActionList.ForEach(t => t());
            }

            var result = RemotingServices.ExecuteMessage(this._target, reqMsg);

            if (this._dynamicAction != null
                && this._dynamicAction.AfterActionList != null
                && this._dynamicAction.AfterActionList.Count > 0)
            {
                this._dynamicAction.AfterActionList.ForEach(t => t());
            }

            return result;
        }
    }
}
