using calc.Operators.Interfaces;
using System;
using System.Collections.Generic;

namespace calc.Operators
{
    public class E : IOperator
    {
        public int NumberOfArguments
        {
            get
            {
                return 0;
            }
        }

        public string OperandName
        {
            get
            {
                return "e";
            }
        }

        public object Do(Stack<object> args)
        {
            OperatorUtils.CheckArgs(args, this);
            return Math.E;
        }
    }
}
