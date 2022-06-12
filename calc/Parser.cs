using calc.Operators.Interfaces;
using System.Collections.Generic;

namespace calc
{
    public class Parser
    {
        public List<IOperator> Operators { get; set; }

        public void ParseDo(string input, Stack<object> stack)
        {
            input = input.Trim();
            if (ParseArgumentAndPutOnStack(input, stack))
            {

            }
            else if (input.Contains(" "))
            {
                var splitArray = input.Split(' ');
                foreach (var arg in splitArray)
                {
                    ParseDo(arg, stack);
                }
            }
            else
            {
                foreach (var operatorItem in Operators)
                {
                    if (input == operatorItem.OperandName)
                    {
                        var returnValue = operatorItem.Do(stack);
                        if (returnValue != null)
                        {
                            stack.Push(returnValue);
                        }
                    }
                }
            }
        }

        private bool ParseArgumentAndPutOnStack(string input, Stack<object> stack)
        {
            double doubleArg;
            bool boolArg;
            if (double.TryParse(input, out doubleArg))
            {
                stack.Push(doubleArg);
                return true;
            }
            else if (bool.TryParse(input, out boolArg))
            {
                stack.Push(boolArg);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
