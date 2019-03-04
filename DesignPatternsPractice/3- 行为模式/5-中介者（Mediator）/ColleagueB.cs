using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Mediator
{
    public class ColleagueB
    {
        private Mediator MediatorObj { set; get; }

        public ColleagueB(Mediator mediator)
        {
            this.MediatorObj = mediator;
        }

        public void OperationA()
        {
            Console.Write("由[ConcreteColleagueB]类调用：");

            if (this.MediatorObj != null)
            {
                this.MediatorObj.OperationA();
            }
        }

        public void OperationB()
        {
            Console.WriteLine("ConcreteColleagueB.Operation");
        }
    }
}
