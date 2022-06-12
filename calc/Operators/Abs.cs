using calc.Operators.Interfaces;
using System;
using System.Collections.Generic;

namespace calc.Operators
{
    public class Abs : IOperator
    {
        public int NumberOfArguments
        {
            get { return 1; }
        }

        public string OperandName
        {
            get { return "abs"; }
        }

        public object Do(Stack<object> args)
        {
            return Math.Abs((double)args.Pop());
        }
    }
}
