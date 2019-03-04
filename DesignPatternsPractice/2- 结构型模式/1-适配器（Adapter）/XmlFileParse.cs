using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Adapter
{
    public class XmlFileParse : XmlFileParseTool, IFileParseService
    {
        public string Parsing()
        {
            return base.FileParsing();
        }
    }
}
