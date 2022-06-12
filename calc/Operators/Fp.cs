using calc.Operators.Interfaces;
using System;
using System.Collections.Generic;

namespace calc.Operators
{
    public class Fp : IOperator
    {
        public int NumberOfArguments
        {
            get { return 1; }
        }

        public string OperandName
        {
            get { return "fp"; }
        }

        public object Do(Stack<object> args)
        {
            OperatorUtils.CheckArgs(args, this);
            var number = (double)(args.Pop());
            if (number > 0.0)
            {
                return Math.Round(number - Math.Floor(number), 4);
            }
            else
            {
                return Math.Round(-Math.Ceiling(number) + number, 4);
            }
        }
    }
}
