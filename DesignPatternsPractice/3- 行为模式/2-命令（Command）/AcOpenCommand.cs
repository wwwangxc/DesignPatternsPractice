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
    public class AcOpenCommand : ICommand
    {
        private AirConditioner _ac = null;

        public AcOpenCommand(AirConditioner ac)
        {
            this._ac = ac;
        }

        public void Execute()
        {
            this._ac.Open();
        }
    }
}
