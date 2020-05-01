using System;
using Xunit;
using project;

namespace tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string[] input = {"5","2","C","D","+"};

            Assert.Equal(30, GameScore.CalculateScores(input));


        }

        [Fact]
        public void Test2()
        {
            string[] input = {"5","-2","4","C","D","9","+","+"};

            Assert.Equal(27, GameScore.CalculateScores(input));


        }

    }
}
