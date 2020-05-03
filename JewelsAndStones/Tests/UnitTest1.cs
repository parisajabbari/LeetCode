using System;
using Xunit;
using project;
namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string s = "aAAbbbb";
            string j = "aA";

            Assert.Equal(3, JewelsAndStones.NumJewelsInStones(j,s));
        }
    }
}
