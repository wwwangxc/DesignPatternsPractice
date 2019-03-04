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
    public class AcCloseCommand : ICommand
    {
        private AirConditioner _ac = null;

        public AcCloseCommand(AirConditioner ac)
        {
            this._ac = ac;
        }

        public void Execute()
        {
            this._ac.Close();
        }
    }
}
