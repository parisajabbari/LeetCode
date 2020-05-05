using System;
using Xunit;
using project;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void ComplementNumberFor5_ShouldReturn2()
        {
            Assert.Equal(2, NumberComplement.FindComplement(5));

        }
        [Fact]
        public void ComplementNumberFor2_ShouldReturn1()
        {
            Assert.Equal(1, NumberComplement.FindComplement(2));

        }
        [Fact]
        public void ComplementNumberFor16_ShouldReturn15()
        {
            Assert.Equal(15, NumberComplement.FindComplement(16));

        }
    }
}
