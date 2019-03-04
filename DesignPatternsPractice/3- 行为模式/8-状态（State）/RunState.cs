using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.State
{
    public class RunState : IState
    {
        public Train Context { private set; get; }

        public RunState(Train context)
        {
            this.Context = context;
        }

        public void OpenDoor()
        {
            throw new Exception("[RunState]：运行状态下禁止开门");
        }

        public void CloseDoor()
        {
            //该操作只能在“开门”状态时使用，不做任何操作
        }

        public void Run()
        {
            //当前状态已经是“运行”状态，不做任何操作
        }

        public void Stop()
        {
            Console.WriteLine("[RunState]：停车");
            this.Context.State = TrainStateFactory.Instance.CreateStopState(this.Context);
        }
    }
}
