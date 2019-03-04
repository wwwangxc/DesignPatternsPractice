using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Singleton
{
    public class SingletonB
    {
        private SingletonB()
        {
            Console.WriteLine("开始初始化SingletonB");
        }

        private static object _sysLock = new object();
        private static SingletonB _instance = null;

        public static SingletonB Instance
        {
            get
            {
                if(_instance == null)
                {
                    lock (_sysLock)
                    {
                        if(_instance == null)
                        {
                            _instance = new SingletonB();
                        }
                    }
                }

                return _instance;
            }
        }

        public void ShowName()
        {
            Console.WriteLine("SingletonB");
        }
    }
}
