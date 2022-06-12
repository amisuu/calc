using calc.Operators.Interfaces;
using System.Collections.Generic;

namespace calc.Operators
{
    public class Decrement : IOperator
    {
        public int NumberOfArguments
        {
            get { return 1; }
        }

        public string OperandName
        {
            get { return "--"; }
        }

        public object Do(Stack<object> args)
        {
            var number = (double)(args.Pop());
            return --number;
        }
    }
}
