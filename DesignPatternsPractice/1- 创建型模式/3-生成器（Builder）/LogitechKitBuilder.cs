using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Builder
{
    public class LogitechKitBuilder : IKitBuilder
    {
        private Kit _kit = null;

        public LogitechKitBuilder()
        {
            this._kit = new Kit();
        }

        public void BuildMouse()
        {
            this._kit.Mouse = new LogitechMouse();
        }

        public void BuildKeyboard()
        {
            this._kit.Keyboard = new LogitechKeyboard();
        }

        public Kit GetKit()
        {
            return this._kit;
        }
    }
}
