using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Command
{
    /// <summary>
    /// 开机命令
    /// </summary>
    public class TvOpenCommand : ICommand
    {
        private Television _tv = null;

        public TvOpenCommand(Television tv)
        {
            this._tv = tv;
        }

        public void Execute()
        {
            this._tv.Open();
        }
    }
}
