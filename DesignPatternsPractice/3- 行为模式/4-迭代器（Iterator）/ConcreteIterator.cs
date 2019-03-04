using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Iterator
{
    public class ConcreteIterator : Iterator
    {
        private int Index { set; get; } = -1;
        private int[] IntArr;
        public ConcreteIterator(int[] intArr)
        {
            this.IntArr = intArr;
        }

        public object Current
        {
            get
            {
                if(this.IntArr == null
                    || this.IntArr.Length < 1
                    || this.Index < 0
                    || this.Index >= this.IntArr.Length)
                {
                    return null;
                }

                return this.IntArr[this.Index];
            }
        }

        public bool Next()
        {
            this.Index++;
            return this.Index < this.IntArr.Length;
        }

        public void Reset()
        {
            this.Index = -1;
        }
    }
}
