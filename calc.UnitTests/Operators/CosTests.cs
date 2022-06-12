using calc.Operators;
using System.Collections.Generic;
using Xunit;

namespace calc.UnitTests.Operators
{
    public class CosTests
    {
        [Fact]
        public void Do_CosOperator_PositiveDoubleNumbers()
        {
            var cos = new Cos();
            var stack = new Stack<object>();

            stack.Push(4.0);

            Assert.Equal(-0.6536436208636119, cos.Do(stack));
        }

        [Fact]
        public void Do_CosOperator_NegativeDoubleNumbers()
        {
            var cos = new Cos();
            var stack = new Stack<object>();

            stack.Push(-3.0);

            Assert.Equal(-0.9899924966004454, cos.Do(stack));
        }
    }
}
