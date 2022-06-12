using calc.Operators.Interfaces;
using System.Collections.Generic;

namespace calc.Operators
{
    public class AND : IOperator
    {
        public int NumberOfArguments
        {
            get { return 2; }
        }

        public string OperandName
        {
            get { return "&"; }
        }

        public object Do(Stack<object> args)
        {
            OperatorUtils.CheckArgs(args, this);
            var second = args.Pop();
            if ((args.Pop()) == second)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
