using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Adapter
{
    public class SqlFileParse : IFileParseService
    {
        public SqlFileParse(IFileParseTool parseTool)
        {
            this._parseTool = parseTool;
        }

        private IFileParseTool _parseTool = null;

        public string Parsing()
        {
            return this._parseTool.FileParsing();
        }
    }
}
