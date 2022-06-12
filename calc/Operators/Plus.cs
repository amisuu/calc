using calc.Operators.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace calc.Operators
{
    public class Plus : IOperator
    {
        public int NumberOfArguments
        {
            get
            {
                return 2;
            }
        }

        public string OperandName
        {
            get
            {
                return "+";
            }
        }

        public object Do(Stack<object> args)
        {
            OperatorUtils.CheckArgs(args, this);
            if (OperatorUtils.IsNumeric(args, this.NumberOfArguments))
            {
                return (double)args.Pop() + (double)args.Pop();
            }
            else if (OperatorUtils.IsString(args, this.NumberOfArguments))
            {
                var secondString = args.Pop();
                StringBuilder sb = new StringBuilder((string)args.Pop());
                return sb.Append(secondString).ToString();
            }
            else
            {
                return null;
            }
        }
    }
}
