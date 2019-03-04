using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Mediator
{
    public class ColleagueA
    {
        private Mediator MediatorObj { set; get; }

        public ColleagueA(Mediator mediator)
        {
            this.MediatorObj = mediator;
        }

        public void OperationA()
        {
            Console.WriteLine("ConcreteColleagueA.Operation");
        }

        public void OperationB()
        {
            Console.Write("由[ConcreteColleagueA]类调用：");

            if (this.MediatorObj != null)
            {
                this.MediatorObj.OperationB();
            }
        }
    }
}
