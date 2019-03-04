using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Memento
{
    public class Originator
    {
        public string State { set; get; } = string.Empty;

        public IMemento CreateMemento()
        {
            return new Memento(this.State);
        }

        public void Restore(IMemento obj)
        {
            var memento = obj as Memento;

            if(memento == null)
            {
                throw new TypeLoadException();
            }

            this.State = memento.State;
        }

        private class Memento : IMemento
        {
            public string State { set; get; } = string.Empty;

            public Memento(string state)
            {
                this.State = state;
            }
        }
    }
}
