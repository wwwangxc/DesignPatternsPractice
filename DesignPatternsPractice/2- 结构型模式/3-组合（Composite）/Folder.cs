using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsPractice.Visitor;

namespace DesignPatternsPractice.Composite
{
    public class Folder : IFile
    {
        public bool IsFolder => true;
        public string Name { set; get; } = string.Empty;
        public IFile Father { set; get; }
        private List<IFile> _childList = new List<IFile>();

        public Folder(string name)
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

            string result = spec + this.Name;
            foreach (IFile child in _childList)
            {
                result += Environment.NewLine + child.ShowMyself();
            }

            return result;
        }

        public IFile GetChild(int index)
        {
            if (index >= this._childList.Count)
            {
                throw new Exception("越界");
            }

            return this._childList[index];
        }

        public void Add(IFile obj)
        {
            IFile father = this;
            while (father != null)
            {
                if (object.ReferenceEquals(obj, father))
                {
                    throw new Exception("循环引用");
                }

                father = father.Father;
            }

            if (this._childList.Exists(t => object.ReferenceEquals(t, obj)))
            {
                throw new Exception("子节点已存在");
            }

            obj.Father = this;
            this._childList.Add(obj);
        }

        public void Remove(IFile obj)
        {
            if (obj.Father == null
                || !this._childList.Exists(t => object.ReferenceEquals(t, obj)))
            {
                throw new Exception("未找到子节点");
            }

            obj.Father = null;
            this._childList.Remove(obj);
        }

        #region 访问者模式相关
        /// <summary>
        /// 访问者模式相关
        /// </summary>
        /// <param name="visitor"></param>
        public void Accept(IFileVisitor visitor)
        {
            foreach (var item in this._childList)
            {
                item.Accept(visitor);
            }

            visitor.Visit(this);
        }
        #endregion
    }
}
