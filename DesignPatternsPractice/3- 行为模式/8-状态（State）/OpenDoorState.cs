using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.State
{
    public class OpenDoorState : IState
    {
        public Train Context { private set; get; }

        public OpenDoorState(Train context)
        {
            this.Context = context;
        }

        public void OpenDoor()
        {
            //当前状态已经是“开门”状态，不做任何操作
        }

        public void CloseDoor()
        {
            Console.WriteLine("[OpenDoorState]：关门");
            this.Context.State = TrainStateFactory.Instance.CreateCloseDoorState(this.Context);
        }
               
        public void Run()
        {
            throw new Exception("[OpenDoorState]：开门状态下禁止运行");
        }

        public void Stop()
        {
            //该操作只能在“运行”状态时使用，不做任何操作
        }
    }
}
