using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Iterator
{
    public class ClassA
    {
        public int[] IntArr { set; get; } = new int[] { 1, 2, 3, 4, 5, 6, 7 };
        public ClassB GetEnumerator()
        {
            Console.WriteLine("ClassA.GetEnumerator");
            Console.WriteLine("------------------------");
            return new ClassB(this);
        }
    }

    public class ClassB
    {
        private int Index { set; get; } = -1;
        private ClassA ClassA { set; get; }

        public ClassB(ClassA classA)
        {
            this.ClassA = classA;
        }

        public int Current
        {
            get
            {
                Console.WriteLine($"[ClassB.Current]：{this.ClassA.IntArr[this.Index]}");
                return this.ClassA.IntArr[this.Index];
            }
        }

        public bool MoveNext()
        {
            this.Index++;
            Console.WriteLine($"[ClassB.MoveNext]：{this.Index < this.ClassA.IntArr.Length}");
            return this.Index < this.ClassA.IntArr.Length;
        }
    }
}
