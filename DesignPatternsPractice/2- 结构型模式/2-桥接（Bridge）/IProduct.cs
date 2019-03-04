using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Bridge
{
    public abstract class Product
    {
        public Product(IBrand brand)
        {
            this._brand = brand;
        }

        public IBrand _brand = null;

        public virtual string ShowMyself()
        {
            return $"{this._brand.GetBrandName()}的产品";
        }
    }
}
