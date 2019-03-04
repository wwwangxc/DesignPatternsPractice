using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice.Interpreter
{
    /// <summary>
    /// 运算解释器
    /// </summary>
    public class OperationInterpreter
    {
        public double Interpret(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                throw new Exception("字符串为空");
            }

            double d;
            if (!double.TryParse(str.Replace("+", string.Empty)
                                    .Replace("-", string.Empty)
                                    .Replace("*", string.Empty)
                                    .Replace("/", string.Empty)
                                    .Replace(".", string.Empty), out d))
            {
                throw new Exception("当前字符串不可进行求和运算");
            }

            str = str.Replace(" ", string.Empty);
            var plusList = str.Split(new string[] { "+" }, StringSplitOptions.RemoveEmptyEntries);
            ValueExpression operationValue = null;
            foreach (var plusItem in plusList)
            {
                ValueExpression minuValue = null;
                var minusList = plusItem.Split(new string[] { "-" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var minuItem in minusList)
                {
                    ValueExpression mulValue = null;
                    var mulList = minuItem.Split(new string[] { "*" }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var mulItem in mulList)
                    {
                        var divList = mulItem.Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
                        ValueExpression divValue = null;
                        foreach (var divItem in divList)
                        {
                            if (divValue == null)
                            {
                                divValue = new ValueExpression(divItem);
                            }
                            else
                            {
                                var divExp = new DivisionExpression(new List<IExpression> { divValue, new ValueExpression(divItem) });
                                divValue = new ValueExpression(divExp.Interpret().ToString());
                            }
                        }

                        if (mulValue == null)
                        {
                            mulValue = divValue;
                        }
                        else
                        {
                            var mulExp = new MultiplicationExpression(new List<IExpression> { mulValue, divValue });
                            mulValue = new ValueExpression(mulExp.Interpret().ToString());
                        }
                    }

                    if (minuValue == null)
                    {
                        minuValue = mulValue;
                    }
                    else
                    {
                        var minExp = new MinusExpression(new List<IExpression> { minuValue, mulValue });
                        minuValue = new ValueExpression(minExp.Interpret().ToString());
                    }
                }

                if (operationValue == null)
                {
                    operationValue = minuValue;
                }
                else
                {
                    var operationExp = new PlusExpression(new List<IExpression> { operationValue, minuValue });
                    operationValue = new ValueExpression(operationExp.Interpret().ToString());
                }
            }

            return operationValue.Interpret();
        }
    }
}
