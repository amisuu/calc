using System;
using System.Collections.Generic;

namespace calc
{
    class ConsoleUserInterface : IUserInterface
    {
        public void WriteStack(Stack<object> stack)
        {
            foreach (var stackItem in stack)
            {
                Console.WriteLine(stackItem.ToString());
            }
            Console.Write(Environment.NewLine);
        }

    }
}
