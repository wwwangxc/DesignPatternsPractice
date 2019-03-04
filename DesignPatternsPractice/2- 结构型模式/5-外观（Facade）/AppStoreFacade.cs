using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Facade
{
    public class AppStoreFacade
    {
        private AppA _appA = null;
        private AppA appA
        {
            get
            {
                if(this._appA == null)
                {
                    this._appA = new AppA();
                }

                return this._appA;
            }
        }

        private AppB _appB = null;
        private AppB appB
        {
            get
            {
                if(this._appB == null)
                {
                    this._appB = new AppB();
                }

                return this._appB;
            }
        }

        public void DownloadAppA()
        {
            this.appA.Download();
            Console.WriteLine("---------");
            this.appA.Install();
        }

        public void DownloadAppB()
        {
            this.appB.Download();
            Console.WriteLine("---------");
            this.appB.Install();
        }
    }
}
