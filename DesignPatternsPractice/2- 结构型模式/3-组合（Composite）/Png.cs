using DesignPatternsPractice.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Composite
{
    public class Png : IFile
    {
        public bool IsFolder => false;
        public string Name { set; get; } = string.Empty;
        public IFile Father { set; get; }

        public Png(string name)
        {
            this.Name = name;
        }

        public string ShowMyself()
        {
            string spec = string.Empty;
            IFile father = this.Father;
            while (father != null)
            {
                spec += "  ";
                father = father.Father;
            }
            return $"{spec + this.Name}.png";
        }

        public IFile GetChild(int index)
        {
            throw new NotImplementedException("Sorry,I have not child");
        }

        public void Add(IFile obj)
        {
            throw new NotImplementedException("Sorry,I have not child");
        }

        public void Remove(IFile obj)
        {
            throw new NotImplementedException("Sorry,I have not child");
        }

        #region 访问者模式相关
        /// <summary>
        /// 访问者模式相关
        /// </summary>
        /// <param name="visitor"></param>
        public void Accept(IFileVisitor visitor)
        {
            visitor.Visit(this);
        }
        #endregion
    }
}
