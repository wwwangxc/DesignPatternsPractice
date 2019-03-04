using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.AbstractFactory
{
    public class CommonFactory : IFactory
    {
        private Type _mouseType = null;
        private Type MouseType
        {
            get
            {
                if(this._mouseType == null)
                {
                    var fullName = System.Configuration.ConfigurationManager.AppSettings["MouseSetting"];
                    this._mouseType = string.IsNullOrWhiteSpace(fullName) ? null : Type.GetType(fullName);
                }

                return this._mouseType;
            }
        }

        private Type _keyboardType = null;
        private Type KeyboardType
        {
            get
            {
                if(this._keyboardType == null)
                {
                    var fullName = System.Configuration.ConfigurationManager.AppSettings["KeyboardSetting"];
                    this._keyboardType = string.IsNullOrWhiteSpace(fullName) ? null : Type.GetType(fullName);
                }

                return this._keyboardType;
            }
        }

        public IKeyBoard CreateKeyboard()
        {
            return Activator.CreateInstance(this.KeyboardType) as IKeyBoard;
        }

        public IMouse CreateMouse()
        {
            return Activator.CreateInstance(this.MouseType) as IMouse;
        }
    }
}
