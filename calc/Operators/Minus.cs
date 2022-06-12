using calc.Operators.Interfaces;
using System.Collections.Generic;

namespace calc.Operators
{
    public class Minus : IOperator
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
                return "-";
            }
        }

        public object Do(Stack<object> args)
        {
            OperatorUtils.CheckArgs(args, this);
            object subtractor = args.Pop();
            return (double)args.Pop() - (double)subtractor;
        }
    }
}
