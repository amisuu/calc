using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    interface IUserInterface
    {
        void WriteStack(Stack<object> stack);
    }
}
