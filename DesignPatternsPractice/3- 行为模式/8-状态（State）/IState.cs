using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.State
{
    public interface IState
    {
        Train Context { get; }
        void OpenDoor();
        void CloseDoor();
        void Run();
        void Stop();
    }
}
