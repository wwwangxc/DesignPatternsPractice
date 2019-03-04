using DesignPatternsPractice.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Visitor
{
    public interface IFileVisitor
    {
        void Visit(Folder folder);
        void Visit(Png png);
        void Visit(Txt txt);
    }
}
