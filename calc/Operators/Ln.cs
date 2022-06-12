using calc.Operators.Interfaces;
using System;
using System.Collections.Generic;

namespace calc.Operators
{
    public class Ln : IOperator
    {
        public int NumberOfArguments
        {
            get { return 1; }
        }

        public string OperandName
        {
            get { return "ln"; }
        }

        public object Do(Stack<object> args)
        {
            OperatorUtils.CheckArgs(args, this);
            return Math.Log((double)args.Pop());
        }
    }
}
