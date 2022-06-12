using calc.Operators.Interfaces;
using System.Collections.Generic;

namespace calc.Operators
{
    public class Multiply : IOperator
    {
        public int NumberOfArguments
        {
            get
            {
                return 2;
            }
        }

        public string OperandName
        {
            get
            {
                return "*";
            }
        }

        public object Do(Stack<object> args)
        {
            OperatorUtils.CheckArgs(args, this);
            object secondArgument = args.Pop();
            return (double)args.Pop() * (double)secondArgument;
        }
    }
}
