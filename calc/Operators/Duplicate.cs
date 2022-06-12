using calc.Operators.Interfaces;
using System.Collections.Generic;

namespace calc.Operators
{
    public class Duplicate : IOperator
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
                return "dup";
            }
        }

        public object Do(Stack<object> args)
        {
            OperatorUtils.CheckArgs(args, this);
            var arg = args.Pop();
            args.Push(arg);
            return arg;
        }
    }
}
