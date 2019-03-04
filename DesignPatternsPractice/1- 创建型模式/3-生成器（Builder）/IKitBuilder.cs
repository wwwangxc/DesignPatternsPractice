using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Builder
{
    public interface IKitBuilder
    {
        void BuildMouse();
        void BuildKeyboard();
        Kit GetKit();
    }
}
