using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Iterator
{
    public class ConcreteAggregate : Aggregate
    {
        private int[] IntArr;
        public ConcreteAggregate()
        {
            this.IntArr = new int[]{1, 2, 3, 4, 5, 6, 7};
        }
        public Iterator CreateIterator()
        {
            return new ConcreteIterator(this.IntArr);
        }
    }
}
