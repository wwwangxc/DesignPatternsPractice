using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.State
{
    public class StopState : IState
    {
        public Train Context { private set; get; }

        public StopState(Train context)
        {
            this.Context = context;
        }

        public void OpenDoor()
        {
            Console.WriteLine("[StopState]：开门");
            this.Context.State = TrainStateFactory.Instance.CreateOpenDoorState(this.Context);
        }

        public void CloseDoor()
        {
            //该操作只能在“开门”状态时使用，不做任何操作
        }

        public void Run()
        {
            //该操作只能在“关门”状态时使用，不做任何操作
        }

        public void Stop()
        {
            //当前状态已经是“停止”状态，不做任何操作
        }
    }
}
