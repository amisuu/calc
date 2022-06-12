using calc.Operators.Interfaces;
using System;
using System.Collections.Generic;

namespace calc.Operators
{
    public class Floor : IOperator
    {
        public int NumberOfArguments
        {
            get { return 1; }
        }

        public string OperandName
        {
            get { return "floor"; }
        }

        public object Do(Stack<object> args)
        {
            OperatorUtils.CheckArgs(args, this);
            return Math.Floor((double)args.Pop());
        }
    }
}
