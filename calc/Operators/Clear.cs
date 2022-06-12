using calc.Operators.Interfaces;
using System.Collections.Generic;

namespace calc.Operators
{
    public class Clear : IOperator
    {
        public int NumberOfArguments
        {
            get { return 0; }
        }

        public string OperandName
        {
            get { return "clr"; }
        }

        public object Do(Stack<object> args)
        {
            OperatorUtils.CheckArgs(args, this);
            args.Clear();
            return null;
        }
    }
}
