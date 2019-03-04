using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Adapter
{
    public class XmlFileParseTool : IFileParseTool
    {
        public string FileParsing()
        {
            return "Xml文件解析中...";
        }
    }
}
