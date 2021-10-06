using System;
using Xunit;
using Tests;

namespace TestFiles
{
    public class LuhnTest
    {
        [Theory]
        [InlineData("4444111144441112", false)]
        [InlineData("4444111144441111", true)]
        [InlineData("4121144444444445", false)]
        [InlineData("4121144444444444", true)]
        public void Check_Card_No(string input, bool output)
        {
            var result = Luhn.CheckNo(input);

            Assert.Equal(output, result);
        }
    }
}
