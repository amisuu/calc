using System.Collections.Generic;

namespace calc.Operators.Interfaces
{
    public interface IOperator
    {
        int NumberOfArguments { get; }
        string OperandName { get; }
        object Do(Stack<object> args);
    }
}
