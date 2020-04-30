using System;
using Xunit;
using project;
using System.Collections.Generic;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void FindAnagrams_ShouldReturnTrue()
        {
             string[] str = {"eat", "tea", "tan", "ate", "nat", "bat"};
            //string[] str = {"eat", "tea", "ate"};
            var actual = Anagrams.FindAnagrams(str);
            var expected = new List<IList<string>>();
            expected.Add(new List<string>{"eat", "tea", "ate"});
            expected.Add(new List<string>{"tan","nat"});
            expected.Add(new List<string>{"bat"});

            Assert.Equal(expected, actual);
        }
    }
}
