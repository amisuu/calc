using calc.Operators.Interfaces;
using System;
using System.Collections.Generic;

namespace calc.Operators
{
    public class Pick : IOperatorPlus
    {
        public int NumberOfArguments
        {
            get { return 1; }
        }

        public string OperandName
        {
            get { return "pick"; }
        }

        public object Do(Stack<object> args, double value)
        {
            OperatorUtils.CheckArgs(args, this);
            var result = 0.0;

            if (args.Contains(value))
            {
                foreach (var arg in args)
                {
                    if (arg.Equals(value))
                    {
                        result = (double)arg;
                    }
                }
            }
            else
            {
                throw new Exception($"In stack there is not {value}.");
            }
            return result;
        }
    }
}
