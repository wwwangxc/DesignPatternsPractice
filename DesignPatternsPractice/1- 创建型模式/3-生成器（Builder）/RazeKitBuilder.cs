using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Builder
{
    public class RazeKitBuilder : IKitBuilder
    {
        private Kit _kit = null;

        public RazeKitBuilder()
        {
            this._kit = new Kit();
        }

        public void BuildMouse()
        {
            this._kit.Mouse = new RazeMouse();
        }

        public void BuildKeyboard()
        {
            this._kit.Keyboard = new RazeKeyboard();
        }

        public Kit GetKit()
        {
            return this._kit;
        }
    }
}
