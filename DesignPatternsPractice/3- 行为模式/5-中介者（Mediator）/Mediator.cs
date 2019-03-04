using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Mediator
{
    public class Mediator
    {
        public ColleagueA ColleagueAObj { set; private get; }
        public ColleagueB ColleagueBObj { set; private get; }
        public ColleagueC ColleagueCObj { set; private get; }

        public void OperationA()
        {
            if(this.ColleagueAObj != null)
            {
                this.ColleagueAObj.OperationA();
            }
        }

        public void OperationB()
        {
            if (this.ColleagueBObj != null)
            {
                this.ColleagueBObj.OperationB();
            }
        }

        public void OperationC()
        {
            if (this.ColleagueCObj != null)
            {
                this.ColleagueCObj.Operation();
            }
        }
    }
}
