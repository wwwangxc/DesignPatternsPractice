using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Flyweight
{
    public interface IShape
    {
        void Draw(ConsoleColor color, int x, int y);
        void Add(IShape shape);
    }
}
