using calc.Operators.Interfaces;
using System;
using System.Collections.Generic;

namespace calc.Operators
{
    public class Round : IOperator
    {
        public int NumberOfArguments
        {
            get { return 1; }
        }

        public string OperandName
        {
            get { return "round"; }
        }

        public object Do(Stack<object> args)
        {
            OperatorUtils.CheckArgs(args, this);
            return Math.Round((double)args.Pop());
        }
    }
}
