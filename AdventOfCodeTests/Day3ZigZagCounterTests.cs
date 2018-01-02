using AdventOfCode;
using Xunit;

namespace AdventOfCodeTests
{
    public class Day3ZigZagCounterTests
    {
        [Fact]
        public void GetNext_ShouldStartWith1()
        {
            var counter = new Day3ZigZagCounter(4);
            Assert.Equal(1, counter.getNext());
            Assert.Equal(2, counter.getNext());
            Assert.Equal(3, counter.getNext());
            Assert.Equal(4, counter.getNext()); //go up to L
            
            Assert.Equal(3, counter.getNext()); //then work back down again
            Assert.Equal(2, counter.getNext());
            Assert.Equal(1, counter.getNext());
            Assert.Equal(0, counter.getNext());
            
            Assert.Equal(1, counter.getNext()); //aaaand finally back up again.
            Assert.Equal(2, counter.getNext());
            Assert.Equal(3, counter.getNext());
        }
        
        [Fact]
        public void GetNext_ShouldWorkWithLayer1()
        {
            var counter = new Day3ZigZagCounter(1);
            Assert.Equal(1, counter.getNext());
            Assert.Equal(0, counter.getNext());
            Assert.Equal(1, counter.getNext());
            Assert.Equal(0, counter.getNext());
        }
    }
}