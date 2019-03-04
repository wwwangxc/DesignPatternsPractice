using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Command
{
    /// <summary>
    /// 命令宏
    /// </summary>
    public class MacorCommand : ICommand
    {
        public List<ICommand> Commands { set; get; } = new List<ICommand>();

        public void Execute()
        {
            foreach (var command in this.Commands)
            {
                command.Execute();
            }
        }
    }
}
