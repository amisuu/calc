using calc.Operators;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace calc.UnitTests.Operators
{
    public class PickTests
    {
        [Fact]
        public void Do_PickOperator_PositiveDoubleNumbers()
        {
            var pick = new Pick();
            var stack = new Stack<object>();

            for (double i = 2.0; i <= 10.0; i += 2)
            {
                stack.Push(i);
            }

            Assert.Contains(stack.ElementAt(2).ToString(), pick.Do(stack, 6.0).ToString());
        }

        [Fact]
        public void Do_PickOperator_NegativeDoubleNumbers()
        {
            var pick = new Pick();
            var stack = new Stack<object>();

            for (double i = -2.0; i >= -10.0; i -= 2)
            {
                stack.Push(i);
            }

            Assert.Contains(stack.ElementAt(4).ToString(), pick.Do(stack, -2.0).ToString());
        }
    }
}
