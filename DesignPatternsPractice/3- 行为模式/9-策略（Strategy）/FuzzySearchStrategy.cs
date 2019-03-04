using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Strategy
{
    /// <summary>
    /// 模糊搜索
    /// </summary>
    public class FuzzySearchStrategy : IStrategy
    {
        public SearchContext Context { set; get; } = null;

        public List<string> Search(string keyword)
        {
            return this.Context.DataList.FindAll(t => t.IndexOf(keyword) > -1);
        }
    }
}
