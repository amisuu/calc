using calc.Operators.Interfaces;
using System;
using System.Collections.Generic;

namespace calc.Operators
{
    public class Min : IOperator
    {
        public int NumberOfArguments
        {
            get { return 1; }
        }

        public string OperandName
        {
            get { return "min"; }
        }

        public object Do(Stack<object> args)
        {
            return Math.Min((double)args.Pop(), (double)args.Pop());
        }
    }
}
