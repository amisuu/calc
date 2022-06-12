using System.Collections.Generic;

namespace calc.Operators.Interfaces
{
    public interface IOperatorPlus
    {
        int NumberOfArguments { get; }
        string OperandName { get; }
        object Do(Stack<object> args, double value);
    }
}
