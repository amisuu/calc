using calc.Operators.Interfaces;
using System.Collections.Generic;

namespace calc.Operators
{
    class LessThanOrEqualTo : IOperator
    {
        public int NumberOfArguments
        {
            get { return 2; }
        }

        public string OperandName
        {
            get { return "<="; }
        }

        public object Do(Stack<object> args)
        {
            OperatorUtils.CheckArgs(args, this);
            var second = args.Pop();
            return ((double)(args.Pop()) <= (double)second);
        }
    }
}
