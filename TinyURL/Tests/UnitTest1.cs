using System;
using Xunit;
using project;


namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void encodingURL_ReturnsANonEmptyString()
        {
            var URL = "www.google.com/tests";
            Assert.NotEqual(string.Empty, TinyURL.Encode(URL));
        }
        [Fact]
        public void decodingTinyURL_ReturnsANonEmptyString()
        {
            var TinyURLInput = "www.TinyURL.com/xxx";
            Assert.NotEqual(string.Empty, TinyURL.Decode(TinyURLInput));
        }

        [Fact]
        public void encodeThedecodedTinyURL_ReturnsOriginalURL()
        {
            var TinyURLInput = "www.google/aaa/bbb";
            Assert.Equal("www.google/aaa/bbb", TinyURL.Decode(TinyURL.Encode(TinyURLInput)));
        }

        [Fact]
        public void LeetCodeTest()
        {
            var TinyURLInput = "http://www.leetcode.com/faq/?id=10";
            Assert.Equal("http://www.leetcode.com/faq/?id=10", TinyURL.Decode(TinyURL.Encode(TinyURLInput)));
        }



    }
}
