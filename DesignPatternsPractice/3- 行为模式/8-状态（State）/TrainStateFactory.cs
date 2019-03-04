using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.State
{
    /// <summary>
    /// 火车状态的享元工厂
    /// </summary>
    public class TrainStateFactory
    {
        //单例模式
        private TrainStateFactory() { }
        private static TrainStateFactory _instance = null;
        private static object _sysLock = new object();
        public static TrainStateFactory Instance
        {
            get
            {
                if(_instance == null)
                {
                    lock (_sysLock)
                    {
                        if(_instance == null)
                        {
                            _instance = new TrainStateFactory();
                        }
                    }
                }

                return _instance;
            }
        }

        /// <summary>
        /// 状态的享元池
        /// </summary>
        private List<IState> StatePool { set; get; } = new List<IState>();

        public IState CreateOpenDoorState(Train context)
        {
            var state = this.StatePool.Find(t => object.ReferenceEquals(t.Context, context) && t is OpenDoorState);

            if(state == null)
            {
                state = new OpenDoorState(context);
                this.StatePool.Add(state);
            }

            return state;
        }

        public IState CreateCloseDoorState(Train context)
        {
            var state = this.StatePool.Find(t => object.ReferenceEquals(t.Context, context) && t is CloseDoorState);

            if (state == null)
            {
                state = new CloseDoorState(context);
                this.StatePool.Add(state);
            }

            return state;
        }

        public IState CreateRunState(Train context)
        {
            var state = this.StatePool.Find(t => object.ReferenceEquals(t.Context, context) && t is RunState);

            if (state == null)
            {
                state = new RunState(context);
                this.StatePool.Add(state);
            }

            return state;
        }

        public IState CreateStopState(Train context)
        {
            var state = this.StatePool.Find(t => object.ReferenceEquals(t.Context, context) && t is StopState);

            if (state == null)
            {
                state = new StopState(context);
                this.StatePool.Add(state);
            }

            return state;
        }
    }
}
