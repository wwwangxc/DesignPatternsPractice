using DesignPatternsPractice.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Builder
{
    public class KitDirector
    {
        public Kit ConstructKit(IKitBuilder builder)
        {
            if(builder == null)
            {
                return null;
            }

            builder.BuildMouse();
            builder.BuildKeyboard();
            return builder.GetKit();
        }
    }
}
