using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Prototype
{
    public class PrototypeManager
    {
        private Dictionary<string, object> PrototypeDict = new Dictionary<string, object>();

        public PrototypeManager()
        {
            this.LoadPrototypes();
        }

        private void LoadPrototypes()
        {
            Kit logitechKit = new Kit();
            logitechKit.Mouse = new LogitechMouse();
            logitechKit.Keyboard = new LogitechKeyboard();
            PrototypeDict.Add("LogitechKit", logitechKit);
        }

        public void AddPrototype(string key, object prototype)
        {
            this.PrototypeDict.Add(key, prototype);
        }

        public object CreateInstance(string key)
        {
            object prototypeObj = this.PrototypeDict[key];
            Type prototypeType = prototypeObj.GetType();
            MethodInfo method = prototypeType.GetMethod("Clone");
            return method.Invoke(prototypeObj, null);
        }
    }
}
