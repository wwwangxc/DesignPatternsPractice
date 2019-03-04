using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Adapter
{
    public class TxtFileParse : IFileParseService
    {
        public string Parsing()
        {
            return "Txt文件解析中...";
        }
    }
}
