using System;
using Xunit;
using assignment;

namespace testcases
{
    public class LengthHelperUnitTest
    {
        [Fact]
        public void Test1()
        {
            var t = new LengthHelper();
            Assert.Equal(0, t.findLength(""));
        }
        [Fact]
        public void Test2()
        {
            var t = new LengthHelper();
            Assert.Equal(3, t.findLength("123"));
        }
        [Fact]
        public void Test3()
        {
            var t = new LengthHelper();
            Assert.Equal(12, t.findLength("123456789010"));
        }
        [Fact]
        public void Test4()
        {
            var t = new LengthHelper();
            Assert.Throws<ArgumentNullException>(() => t.findLength(null));
        }


        [Theory]
        [InlineData("")]
        [InlineData("123")]
        [InlineData("123456789010")]
        public void TestMultiple(string str)
        {
            var t = new LengthHelper();
            Assert.Equal(str.Length, t.findLength(str));
        }

    }
}

