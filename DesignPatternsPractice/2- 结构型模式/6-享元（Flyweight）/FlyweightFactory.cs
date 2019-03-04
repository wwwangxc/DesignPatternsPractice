using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Flyweight
{
    public class FlyweightFactory
    {
        private FlyweightFactory() { }
        private static FlyweightFactory _instance = null;
        private static object _sysLock = new object();
        public static FlyweightFactory Instance
        {
            get
            {
                if(_instance == null)
                {
                    lock (_sysLock)
                    {
                        if(_instance == null)
                        {
                            _instance = new FlyweightFactory();
                        }
                    }
                }

                return _instance;
            }
        }

        private Dictionary<string, IShape> _shapePool = new Dictionary<string, IShape>();
        public int PoolSize => this._shapePool.Count;

        public IShape CreateCircle(string text)
        {
            IShape shape = this._shapePool.ContainsKey(text) && this._shapePool[text] is Circle ?
                            this._shapePool[text] : null;

            if(shape == null)
            {
                shape = new Circle(text);
                this._shapePool.Add(text, shape);
            }

            return shape;
        }

        public IShape CreateRectangle(string text)
        {
            IShape shape = this._shapePool.ContainsKey(text) && this._shapePool[text] is Rectangle ?
                            this._shapePool[text] : null;

            if (shape == null)
            {
                shape = new Rectangle(text);
                this._shapePool.Add(text, shape);
            }

            return shape;
        }

        public IShape CreateComposite()
        {
            return new ShapeComposite();
        }
    }
}
