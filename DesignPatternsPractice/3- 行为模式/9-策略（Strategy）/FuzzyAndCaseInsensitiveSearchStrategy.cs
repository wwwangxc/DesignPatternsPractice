using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Strategy
{
    /// <summary>
    /// 模糊且不区分大小写
    /// </summary>
    public class FuzzyAndCaseInsensitiveSearchStrategy : IStrategy
    {
        public SearchContext Context { set; get; } = null;

        public List<string> Search(string keyword)
        {
            return this.Context.DataList.FindAll(t => t.ToLower().IndexOf(keyword.ToLower()) > -1);
        }
    }
}
