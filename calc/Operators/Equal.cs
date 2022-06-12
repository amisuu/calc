using calc.Operators.Interfaces;
using System;
using System.Collections.Generic;

namespace calc.Operators
{
    public class Equal : IOperator
    {
        public int NumberOfArguments
        {
            get { return 2; }
        }

        public string OperandName
        {
            get { return "=="; }
        }

        public object Do(Stack<object> args)
        {
            OperatorUtils.CheckArgs(args, this);
            try
            {
                var second = args.Pop();
                var first = args.Pop();
                return (first.Equals(second));
            }
            catch (Exception e)
            {
                throw new ArgumentException("Only double type", e.Message);
            }
        }
    }
}
