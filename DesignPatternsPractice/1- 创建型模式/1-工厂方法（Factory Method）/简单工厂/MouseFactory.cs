using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.FactoryMethod.SimpleFactory
{
    public class MouseFactory
    {
        public IMouse CreateMouse(string brand)
        {
            if (string.IsNullOrEmpty(brand))
            {
                return null;
            }

            //if(brand == "罗技")
            //{
            //    return new LogitechMouse();
            //}
            //else if (brand == "雷蛇")
            //{
            //    return new RazeMouse();
            //}
            //else
            //{
            //    return null;
            //}
            
            //反射鼠标实体
            return Activator.CreateInstance(Type.GetType(brand)) as IMouse;
        }
    }
}
