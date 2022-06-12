using calc.Operators.Interfaces;
using System.Collections.Generic;

namespace calc.Operators
{
    public class Square : IOperator
    {
        public int NumberOfArguments
        {
            get
            {
                return 1;
            }
        }

        public string OperandName
        {
            get
            {
                return "sqrt";
            }
        }

        public object Do(Stack<object> args)
        {
            OperatorUtils.CheckArgs(args, this);
            var value = (double)args.Pop();
            return value * value;
        }
    }
}
