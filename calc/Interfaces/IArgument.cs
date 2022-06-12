using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    interface IArgument
    {
        ArgumentType Type { get; }
        object NumericValue { get; }
        string StringValue { get; }
    }

    enum ArgumentType
    {
        Float,
        Int,
        String
    }
}
