using calc.Operators;
using System.Collections.Generic;
using Xunit;

namespace calc.UnitTests.Operators
{
    public class PlusTests
    {
        [Fact]
        public void Do_PlusOperator_PositiveDoubleNumbers()
        {
            var plus = new Plus();
            var stack = new Stack<object>();

            stack.Push(10000.42);
            stack.Push(11111.33);

            Assert.Equal(21111.75, plus.Do(stack));
        }

        [Fact]
        public void Do_PlusOperator_NegativeDoubleNumbers()
        {
            var plus = new Plus();
            var stack = new Stack<object>();

            stack.Push(-3456.33);
            stack.Push((-1111.45));

            Assert.Equal(-4567.78, plus.Do(stack));
        }
    }
}
