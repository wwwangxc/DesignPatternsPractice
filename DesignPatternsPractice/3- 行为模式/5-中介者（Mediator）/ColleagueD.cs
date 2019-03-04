using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Mediator
{
    public class ColleagueD
    {
        private Mediator MediatorObj { set; get; }

        public ColleagueD(Mediator mediator)
        {
            this.MediatorObj = mediator;
        }

        public void Operation()
        {
            Console.Write("由[ConcreteColleagueD]类调用：");

            if (this.MediatorObj != null)
            {
                this.MediatorObj.OperationC();
            }
        }
    }
}
