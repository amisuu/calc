using calc.Operators.Interfaces;
using System;
using System.Collections.Generic;

namespace calc.Operators
{
    public class Exponentiation : IOperator
    {
        public int NumberOfArguments
        {
            get { return 1; }
        }

        public string OperandName
        {
            get { return "exp"; }
        }

        public object Do(Stack<object> args)
        {
            OperatorUtils.CheckNumberOfArguments(args, this.NumberOfArguments);
            var number = (double)args.Pop();
            return Math.Pow(number, 2);
        }
    }
}
