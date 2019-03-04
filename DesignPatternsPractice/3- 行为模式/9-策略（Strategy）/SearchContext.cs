using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Strategy
{
    public class SearchContext
    {
        public SearchContext(IStrategy strategy)
        {
            this.Strategy = strategy;
            this.Strategy.Context = this;
            this.DataList = new List<string>
            {
                "abc","Abc","ABc","ABC"
            };
        }

        private IStrategy Strategy { set; get; } = null;
        /// <summary>
        /// 模拟数据
        /// </summary>
        public List<string> DataList { private set; get; } = new List<string>();

        public List<string> Search(string keyword)
        {
            return this.Strategy.Search(keyword);
        }
    }
}
