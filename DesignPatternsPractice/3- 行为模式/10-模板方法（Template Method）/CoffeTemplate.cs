using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Template
{
    public abstract class CoffeTemplate
    {
        public void MakeCoffe()
        {
            this.AddEspresso();     //加入一是浓缩咖啡
            this.AddLiquid();       //加入液体
            this.IntoContainer();   //装入容器
        }

        private void AddEspresso()
        {
            Console.WriteLine("加入一份意式浓缩咖啡");
        }

        /// <summary>
        /// 钩子操作，由子类选择性重写
        /// </summary>
        protected virtual void AddLiquid() { }

        /// <summary>
        /// 原语操作，由子类实现
        /// </summary>
        protected abstract void IntoContainer();
    }
}