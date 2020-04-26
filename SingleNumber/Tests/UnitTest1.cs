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
            int[] nums = {1,2,2};
            Assert.Equal(1, Solution.SingleNumber(nums));
        }

        [Fact]
        public void Test2()
        {
            int[] nums = {2,1,2};
            Assert.Equal(1, Solution.SingleNumber(nums));
        }

        [Fact]
        public void Test3()
        {
            int[] nums = {1,3,1,-1,3};
            Assert.Equal(-1, Solution.SingleNumber(nums));
        }
        
        [Fact]
        public void Test4()
        {
            int[] nums = {1,3,1,5,3};
            Assert.Equal(5, Solution.SingleNumber(nums));
        }

        [Fact]
        public void Test5()
        {
            int[] nums = {1,2,2};
            Assert.Equal(1, Solution.SingleNumDic(nums));
        }

        [Fact]
        public void Test6()
        {
            int[] nums = {2,1,2};
            Assert.Equal(1, Solution.SingleNumDic(nums));
        }

        [Fact]
        public void Test7()
        {
            int[] nums = {1,3,1,-1,3};
            Assert.Equal(-1, Solution.SingleNumDic(nums));
        }
        
        [Fact]
        public void Test8()
        {
            int[] nums = {1,3,1,5,3};
            Assert.Equal(5, Solution.SingleNumDic(nums));
        }



    }
}
