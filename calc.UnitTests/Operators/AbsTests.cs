using calc.Operators;
using System.Collections.Generic;
using Xunit;

namespace calc.UnitTests.Operators
{
    public class AbsTest
    {
        [Fact]
        public void Do_AbsOperator_PositiveDoubleNumbers()
        {
            var abs = new Abs();
            var stack = new Stack<object>();

            stack.Push(10.0);

            Assert.Equal(10.0, abs.Do(stack));
        }

        [Fact]
        public void Do_AbsOperator_NegativeDoubleNumbers()
        {
            var abs = new Abs();
            var stack = new Stack<object>();

            stack.Push(-10.0);

            Assert.Equal(10.0, abs.Do(stack));
        }
    }
}
