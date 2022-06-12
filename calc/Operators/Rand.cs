using calc.Operators.Interfaces;
using System;
using System.Collections.Generic;

namespace calc.Operators
{
    public class Rand : IOperator
    {
        Random random = new Random(100);
        public int NumberOfArguments
        {
            get { return 0; }
        }

        public string OperandName
        {
            get { return "rand"; }
        }

        public object Do(Stack<object> args)
        {
            return random.NextDouble();
        }
    }
}
