using calc.Operators.Interfaces;
using System.Collections.Generic;

namespace calc.Operators
{
    class Depth : IOperator
    {
        public int NumberOfArguments
        {
            get { return 0; }
        }

        public string OperandName
        {
            get { return "depth"; }
        }

        public object Do(Stack<object> args)
        {
            return args.Count;
        }
    }
}
