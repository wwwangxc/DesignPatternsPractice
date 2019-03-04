using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Interpreter
{
    /// <summary>
    /// 终结符表达式
    /// </summary>
    public class ValueExpression : IExpression
    {
        private string Value { set; get; } = string.Empty;

        public ValueExpression(string value)
        {
            this.Value = value;
        }

        public double Interpret()
        {
            return Convert.ToDouble(this.Value);
        }
    }
}
