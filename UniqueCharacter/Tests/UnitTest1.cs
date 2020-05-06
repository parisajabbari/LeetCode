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
            var s = "xabb";
            Assert.Equal(0, UniqueCharacter.FindFirstUniqChar(s));
            
        }

        [Fact]
        public void Test2()
        {
            var s = "loveleetcode";
            Assert.Equal(2, UniqueCharacter.FindFirstUniqChar(s));
            
        }
        
        [Fact]
        public void Test3()
        {
            var s = "leetcode";
            Assert.Equal(0, UniqueCharacter.FindFirstUniqChar(s));
            
        }

        [Fact]
        public void Test4()
        {
            var s = "z";
            Assert.Equal(0, UniqueCharacter.FindFirstUniqChar(s));
            
        }

        [Fact]
        public void Test5()
        {
            var s = "";
            Assert.Equal(-1, UniqueCharacter.FindFirstUniqChar(s));
            
        }
    }
}
