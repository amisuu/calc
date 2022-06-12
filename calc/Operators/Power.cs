using calc.Operators.Interfaces;
using System;
using System.Collections.Generic;

namespace calc.Operators
{
    public class Power : IOperator
    {
        public int NumberOfArguments
        {
            get { return 2; }
        }

        public string OperandName
        {
            get { return "pow"; }
        }

        public object Do(Stack<object> args)
        {
            OperatorUtils.CheckNumberOfArguments(args, this.NumberOfArguments);
            var y = (double)args.Pop();
            var x = (double)args.Pop();
            return Math.Pow(x, y);
        }
    }
}
