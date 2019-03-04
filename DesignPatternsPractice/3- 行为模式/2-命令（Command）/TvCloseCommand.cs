using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Command
{
    /// <summary>
    /// 关机命令
    /// </summary>
    public class TvCloseCommand : ICommand
    {
        private Television _tv = null;

        public TvCloseCommand(Television tv)
        {
            this._tv = tv;
        }

        public void Execute()
        {
            this._tv.Close();
        }
    }
}
