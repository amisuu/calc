using calc.Operators.Interfaces;
using System;
using System.Collections.Generic;

namespace calc.Operators
{
    public class Max : IOperator
    {
        public int NumberOfArguments
        {
            get { return 1; }
        }

        public string OperandName
        {
            get { return "max"; }
        }

        public object Do(Stack<object> args)
        {
            return Math.Max((double)args.Pop(), (double)args.Pop());
        }
    }
}
