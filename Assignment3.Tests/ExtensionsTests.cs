using System;
using Xunit;

namespace BDSA2020.Assignment02.Tests
{
    public class ExtensionsTests
    {
        [Fact]
        public void IsSecure_given_https_returns_true()
        {
            var input = new Uri("https://google.dk");
            Assert.True(input.IsSecure());

        }
        [Fact]
        public void IsSecure_given_http_returns_false()
        {
            var input = new Uri("http://google.dk");
            Assert.False(input.IsSecure());
        }
        [Fact]
        public void WordCount_given_hej_med_dig_returns_3()
        {
            var input = "hej med dig";
            Assert.Equal(3, input.WordCount());

        }
        [Fact]
        public void WordCount_given_hej_returns_1()
        {
            var input = "hej";
            Assert.Equal(1, input.WordCount());

        }



    }
}
