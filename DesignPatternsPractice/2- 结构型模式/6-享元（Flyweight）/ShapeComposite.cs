using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Flyweight
{
    public class ShapeComposite : IShape
    {
        private List<IShape> shapeList = new List<IShape>();

        public ShapeComposite()
        {
            Console.WriteLine($"开始实例化ShapeComposite");
        }

        public void Draw(ConsoleColor color, int x, int y)
        {
            Console.WriteLine($"ShapeComposite Draw");
            foreach (var shape in this.shapeList)
            {
                shape.Draw(color, x, y);
            }
        }

        public void Add(IShape shape)
        {
            if(shape == null)
            {
                return;
            }

            this.shapeList.Add(shape);
        }
    }
}
