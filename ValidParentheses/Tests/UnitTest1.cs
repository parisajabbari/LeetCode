using System;
using Xunit;
using project;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void ValidateParentheses_ReturnsTrue()
        {
            var str = "{[[]{}]}()()";
            Assert.True(ValidParentheses.Validate(str));
        }
    }
}
