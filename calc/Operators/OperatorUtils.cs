using calc.Operators.Interfaces;
using System;
using System.Collections.Generic;

namespace calc.Operators
{
    public static class OperatorUtils
    {
        public static void CheckArgs(Stack<object> args, IOperator operatorItem)
        {
            CheckNumberOfArguments(args, operatorItem.NumberOfArguments);
        }

        public static void CheckArgs(Stack<object> args, IOperatorPlus operatorItem)
        {
            CheckNumberOfArguments(args, operatorItem.NumberOfArguments);
        }

        internal static bool IsNumeric(Stack<object> args, int numberOfArguments)
        {
            CheckNumberOfArguments(args, numberOfArguments);
            return IsOfType(args, numberOfArguments, typeof(double));
        }

        internal static bool IsString(Stack<object> args, int numberOfArguments)
        {
            CheckNumberOfArguments(args, numberOfArguments);
            return IsOfType(args, numberOfArguments, typeof(string));
        }

        internal static bool IsOfType(Stack<object> args, int numberOfArguments, Type type)
        {
            bool allIsTypable = true;
            var stackArr = args.ToArray();
            for (int i = 0; i < numberOfArguments; i++)
            {
                if (stackArr[i].GetType() != type)
                 {
                    allIsTypable = false;
                }
            }
            return allIsTypable;
        }

        internal static void CheckNumberOfArguments(Stack<object> args, int numberOfArguments)
        {
            if (args.Count < numberOfArguments)
            {
                throw new ArgumentException("Wrong number of arguments");
            }
        }

    }
}
