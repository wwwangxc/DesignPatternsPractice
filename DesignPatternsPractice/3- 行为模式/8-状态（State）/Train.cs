using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.State
{
    public class Train
    {
        private IState _stateObj = null;
        public IState State { set => this._stateObj = value; }

        public void OpenDoor()
        {
            this._stateObj.OpenDoor();
        }

        public void CloseDoor()
        {
            this._stateObj.CloseDoor();
        }

        public void Run()
        {
            this._stateObj.Run();
        }

        public void Stop()
        {
            this._stateObj.Stop();
        }
    }
}
