using calc.Operators;
using System.Collections.Generic;
using Xunit;

namespace calc.UnitTests.Operators
{
    public class CeilingTests
    {
        [Fact]
        public void Do_CeilingOperator_PositiveDoubleNumbers()
        {
            var ceil = new Ceiling();
            var stack = new Stack<object>();

            stack.Push(56.1234);

            Assert.Equal(57.0, ceil.Do(stack));
        }

        [Fact]
        public void Do_CeilingOperator_NegativeDoubleNumbers()
        {
            var ceil = new Ceiling();
            var stack = new Stack<object>();

            stack.Push(-32.56);

            Assert.Equal(-32.0, ceil.Do(stack));
        }
    }
}
