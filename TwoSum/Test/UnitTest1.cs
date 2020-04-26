using System;
using Xunit;
using project;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] nums = {2, 7, 3, 4};
            int[] output = {0, 1};
            Assert.Equal(output, Solution.TwoSum(nums, 9));

        }

        [Fact]
        public void Test2()
        {
            int[] nums = {2, 3, 7, 4};
            int[] output = {0, 2};
            Assert.Equal(output, Solution.TwoSum(nums, 9));

        }

        [Fact]
        public void Test3()
        {
            int[] nums = {3,2,4};
            int[] output = {1, 2};
            Assert.Equal(output, Solution.TwoSum(nums, 6));

        }
    }
}
