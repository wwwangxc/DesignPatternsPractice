using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Adapter
{
    public class SqlFileParseTool : IFileParseTool
    {
        public string FileParsing()
        {
            return "Sql文件解析中...";
        }
    }
}
