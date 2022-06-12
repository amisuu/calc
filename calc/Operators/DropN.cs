using calc.Operators.Interfaces;
using System.Collections.Generic;

namespace calc.Operators
{
    public class DropN : IOperator
    {
        public int NumberOfArguments
        {
            get
            {
                return 1;
            }
        }

        public string OperandName
        {
            get
            {
                return "dropn";
            }
        }

        public object Do(Stack<object> args)
        {
            OperatorUtils.CheckNumberOfArguments(args, this.NumberOfArguments);
            int i = 0;
            while (i == this.NumberOfArguments)
            {
                args.Pop();
                i++;
            }
            return null;
        }
    }
}
