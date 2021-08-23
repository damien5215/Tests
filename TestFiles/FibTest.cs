using System;
using Xunit;
using Tests;

namespace TestFiles
{
    public class FibTest
    {
        [Fact]
        public void Caculate_Fib_Of_11()
        {
            var result = Fibonacci.Fib(11);

            Assert.Equal(89, result);
        }

        [Fact]
        public void Caculate_Fib_Of_23()
        {
            var result = Fibonacci.Fib(23);

            Assert.Equal(28657, result);
        }

        [Fact]
        public void Caculate_Fib_Of_44()
        {
            var result = Fibonacci.Fib(44);

            Assert.Equal(701408733, result);
        }

        [Fact]
        public void Caculate_Fib_Of_68()
        {
            var result = Fibonacci.Fib(68);

            Assert.Equal(72723460248141, result);
        }
    }
}
