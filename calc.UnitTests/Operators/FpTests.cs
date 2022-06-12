using calc.Operators;
using System.Collections.Generic;
using Xunit;

namespace calc.UnitTests.Operators
{
    public class FpTests
    {
        [Fact]
        public void Do_FpOperator_PositiveDoubleNumbers()
        {
            var fp = new Fp();
            var stack = new Stack<object>();

            stack.Push(4.34);

            Assert.Equal(0.3400, fp.Do(stack));
        }

        [Fact]
        public void Do_FpOperator_NegativeDoubleNumbers()
        {
            var fp = new Fp();
            var stack = new Stack<object>();

            stack.Push(-1.4674);

            Assert.Equal(-0.4674, fp.Do(stack));
        }
    }
}
