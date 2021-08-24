using System;
using Xunit;
using Tests;

namespace TestFiles
{
    public class FibTest
    {
        [Theory]
        [InlineData(11, 89)]
        [InlineData(23, 28657)]
        [InlineData(44, 701408733)]
        [InlineData(68, 72723460248141)]
        public void Caculate_Fib(int input, double output)
        {
            var result = Fibonacci.Fib(input);

            Assert.Equal(output, result);
        }
    }
}
