using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Flyweight
{
    public class Rectangle : IShape
    {
        private string _text = string.Empty;

        public Rectangle(string text)
        {
            this._text = text;
            Console.WriteLine($"开始实例化Rectangle [{text}]");
        }

        public void Draw(ConsoleColor color, int x, int y)
        {
            Console.WriteLine($"Rectangle Draw [Text: {this._text}, Color: {color.ToString()}, 坐标x: {x} y: {y}]");
        }

        public void Add(IShape shape)
        {
            throw new NotImplementedException("Sorry,I can not execute add function");
        }
    }
}
