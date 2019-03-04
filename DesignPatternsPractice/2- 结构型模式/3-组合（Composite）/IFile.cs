using DesignPatternsPractice.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Composite
{
    public interface IFile
    {
        IFile Father { set; get; }
        bool IsFolder { get; }
        string ShowMyself();
        IFile GetChild(int index);
        void Add(IFile obj);
        void Remove(IFile obj);

        /// <summary>
        /// 访问者模式相关
        /// </summary>
        /// <param name="visitor"></param>
        void Accept(IFileVisitor visitor);
    }
}
