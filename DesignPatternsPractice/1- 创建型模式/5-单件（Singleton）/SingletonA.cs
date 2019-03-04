using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Singleton
{
    public class SingletonA
    {
        private SingletonA()
        {
            Console.WriteLine("开始初始化SingletonA");
        }

        private static SingletonA _instance = new SingletonA();

        public static SingletonA Instance
        {
            get
            {
                return _instance;
            }
        }

        public void ShowName()
        {
            Console.WriteLine("SingletonA");
        }
    }
}
