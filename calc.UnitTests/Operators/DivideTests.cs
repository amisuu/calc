using calc.Operators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace calc.UnitTests.Operators
{
    public class DivideTests
    {
        [Fact]
        public void Do_DivideOperator_PositiveDoubleNumbers()
        {
            var divide = new Divide();
            var stack = new Stack<object>();

            stack.Push(33.0);
            stack.Push(11.0);

            Assert.Equal(3.0, divide.Do(stack));
        }

        [Fact]
        public void Do_DivideOperator_NegativeDoubleNumbers()
        {
            var divide = new Divide();
            var stack = new Stack<object>();

            stack.Push(-120.0);
            stack.Push(-30.0);

            Assert.Equal(4.0, divide.Do(stack));
        }
    }
}
