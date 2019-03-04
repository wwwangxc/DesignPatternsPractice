using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Memento
{
    public class ChangeStateCommand
    {
        private Originator OriginatorObj { set; get; } = null;
        private IMemento MementoObj { set; get; } = null;

        public ChangeStateCommand(Originator originator)
        {
            this.OriginatorObj = originator;
        }

        public void Execute(string state)
        {
            this.MementoObj = this.OriginatorObj.CreateMemento();
            this.OriginatorObj.State = state;
        }

        public void Undo()
        {
            this.OriginatorObj.Restore(this.MementoObj);
        }
    }
}
