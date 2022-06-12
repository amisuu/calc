using calc.Operators.Interfaces;
using System.Collections.Generic;

namespace calc.Operators
{
    public class Negative : IOperator
    {
        public int NumberOfArguments
        {
            get { return 1; }
        }

        public string OperandName
        {
            get { return "!"; }
        }

        public object Do(Stack<object> args)
        {
            return -(double)(args.Pop());
        }
    }
}
