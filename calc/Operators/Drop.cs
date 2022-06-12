using calc.Operators.Interfaces;
using System.Collections.Generic;

namespace calc.Operators
{
    class Drop : IOperator
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
                return "drop";
            }
        }

        public object Do(Stack<object> args)
        {
            OperatorUtils.CheckArgs(args, this);
            args.Pop();
            return null;
        }
    }
}
