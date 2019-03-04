using DesignPatternsPractice.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Visitor
{
    /// <summary>
    /// 统计文件夹个数的访问者
    /// </summary>
    public class FolderSumVisitor : IFileVisitor
    {
        public int Sum { private set; get; } = 0;

        public void Visit(Folder folder) { this.Sum++; }

        public void Visit(Png png) { }

        public void Visit(Txt txt) { }
    }
}
