using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Strategy
{
    public interface IStrategy
    {
        SearchContext Context { set; get; }
        List<string> Search(string keyword);
    }
}
