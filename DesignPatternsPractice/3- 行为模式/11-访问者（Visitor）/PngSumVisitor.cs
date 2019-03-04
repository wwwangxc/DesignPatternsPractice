using DesignPatternsPractice.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Visitor
{
    /// <summary>
    /// 统计png文件个数的访问者
    /// </summary>
    public class PngSumVisitor : IFileVisitor
    {
        public int Sum { private set; get; } = 0;

        public void Visit(Folder folder) { }

        public void Visit(Png png) { this.Sum++; }

        public void Visit(Txt txt) { }
    }
}
