using System.Globalization;
using AdventOfCode;
using Xunit;

namespace AdventOfCodeTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }
        
        [Fact]
        public void SumsAllDigitsIfTheSame()
        {
            int result = Day1.notHuman("1111");
            
            Assert.Equal(4, result);
        }
        
        [Fact]
        public void SumsDigitsTheSameAsFollowing()
        {
            int result = Day1.notHuman("1122");
            
            Assert.Equal(3, result);
        }
        
        [Fact]
        public void NoSumIfNoDigitsMatch()
        {
            int result = Day1.notHuman("1234");
            
            Assert.Equal(0, result);
        }
        
        [Fact]
        public void SumIfMatchWrappingAround()
        {
            int result = Day1.notHuman("91212129");
            
            Assert.Equal(9, result);
        }
        
    }
}