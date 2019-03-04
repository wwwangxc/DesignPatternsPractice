using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Singleton
{
    public class SingletonC
    {
        private SingletonC()
        {
            Console.WriteLine("开始初始化SingletonC");
        }

        private class SingletonCHelper
        {
            public static SingletonC _instance = new SingletonC();
        }

        public static SingletonC Instance
        {
            get
            {
                return SingletonCHelper._instance;
            }
        }

        public void ShowName()
        {
            Console.WriteLine("SingletonC");
        }
    }
}
