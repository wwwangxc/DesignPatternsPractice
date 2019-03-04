using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Adapter
{
    public class FileParse : IFileParseService, IFileParseTool
    {
        private IFileParseService _parseService = null;
        private IFileParseTool _parseTool = null;

        public FileParse(IFileParseService parseService)
        {
            this._parseService = parseService;
        }

        public FileParse(IFileParseTool parseTool)
        {
            this._parseTool = parseTool;
        }

        /// <summary>
        /// 接口IFileParseTool的实现
        /// </summary>
        /// <returns></returns>
        public string FileParsing()
        {
            return this._parseService.Parsing();
        }

        /// <summary>
        /// 接口IFileParseService的实现
        /// </summary>
        /// <returns></returns>
        public string Parsing()
        {
            return this._parseTool.FileParsing();
        }
    }
}
