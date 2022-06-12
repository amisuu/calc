using calc.Operators.Interfaces;
using System;
using System.Collections.Generic;

namespace calc.Operators
{
    public class Factorial : IOperator
    {
        public int NumberOfArguments
        {
            get { return 1; }
        }

        public string OperandName
        {
            get { return "fact"; }
        }

        public object Do(Stack<object> args)
        {
            OperatorUtils.CheckArgs(args, this);
            var number = (double)args.Pop();

            if (number % 1 != 0)
            {
                throw new ArgumentException("Argument is not an integer");
            }
            if (number < 0)
            {
                throw new ArgumentException("Argument is negative");
            }
            if (number > 100)
            {
                throw new ArgumentOutOfRangeException("Too big argument");
            }

            double result = 1.0;
            for (var i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
