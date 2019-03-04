using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.State
{
    public class CloseDoorState : IState
    {
        public Train Context { private set; get; }

        public CloseDoorState(Train context)
        {
            this.Context = context;
        }

        public void OpenDoor()
        {
            Console.WriteLine("[CloseDoorState]：开门");
            this.Context.State = TrainStateFactory.Instance.CreateOpenDoorState(this.Context);
        }

        public void CloseDoor()
        {
            //当前状态已经是“关门”状态，不做任何操作
        }

        public void Run()
        {
            Console.WriteLine("[CloseDoorState]：开车");
            this.Context.State = TrainStateFactory.Instance.CreateRunState(this.Context);
        }

        public void Stop()
        {
            //该操作只能在“运行”状态时使用，不做任何操作
        }
    }
}
