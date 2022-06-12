using calc.Operators.Interfaces;
using System.Collections.Generic;

namespace calc.Operators
{
    public class Swap : IOperator
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
                return "swap";
            }
        }

        public object Do(Stack<object> args)
        {
            OperatorUtils.CheckArgs(args, this);
            var arg1 = args.Pop();
            var arg2 = args.Pop();
            args.Push(arg1);
            args.Push(arg2);
            return null;
        }
    }
}
