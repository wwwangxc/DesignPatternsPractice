using DesignPatternsPractice.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Visitor
{
    /// <summary>
    /// 统计txt文件名称列表的访问者
    /// </summary>
    public class TxtNameVisitor : IFileVisitor
    {
        public List<string> NameList { private set; get; } = new List<string>();

        public void Visit(Folder folder) { }

        public void Visit(Png png) { }

        public void Visit(Txt txt) { this.NameList.Add(txt.Name); }
    }
}
