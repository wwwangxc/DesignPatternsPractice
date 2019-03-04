using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Memento
{
    public class Caretaker
    {
        public IMemento Memento { set; get; } = null;
    }
}
