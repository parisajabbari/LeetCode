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
            Assert.False(RansomeNote.CanConstruct("a", "b"));
        }
        [Fact]
        public void Test2()
        {
            Assert.False(RansomeNote.CanConstruct("aa", "ab"));
        }
        [Fact]
        public void Test3()
        {
            Assert.True(RansomeNote.CanConstruct("aa", "aab"));
        }
    [Fact]
        public void Test4()
        {
            Assert.True(RansomeNote.CanConstruct("fffbfg", "effjfggbffjdgbjjhhdegh"));
        }

            [Fact]
        public void Test5()
        {
            Assert.True(RansomeNote.CanConstruct("", ""));
        }

        [Fact]
        public void Test6()
        {
            Assert.True(RansomeNote.CanConstruct("", "a"));
        }

        [Fact]
        public void Test7()
        {
            Assert.False(RansomeNote.CanConstruct("fihjjjjei", "hjibagacbhadfaefdjaeaebgi"));
        }

    }
}
