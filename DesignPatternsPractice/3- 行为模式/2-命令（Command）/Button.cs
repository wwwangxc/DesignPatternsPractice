using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Command
{
    /// <summary>
    /// 命令的调用者
    /// </summary>
    public class Button
    {
        public ICommand Command { set; get; }

        public Button(ICommand command)
        {
            this.Command = command;
        }

        public void Click()
        {
            this.Command.Execute();
        }
    }
}
