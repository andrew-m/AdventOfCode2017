using System.Collections.Generic;
using AdventOfCode;
using Xunit;

namespace AdventOfCodeTests
{
    public class Day3CalcullatorsTests
    {
        [Fact]
        public void ShouldCalculateLayerFor1()
        {
            int result = Day3Calculators.GetLayer(1);
            
            Assert.Equal(0, result);
        }
        
        [Fact]
        public void ShouldCalculateLayerFor2To9()
        {
            var range = Day3Calculators.Range(2, 9);
            var expectedLayer = 1;

            assertValuesInRangeAreInLayer(range, expectedLayer);
        }

        [Fact]
        public void ShouldCalculateLayerFor10To25()
        {
            var range = Day3Calculators.Range(10, 25);
            var expectedLayer = 2;

            assertValuesInRangeAreInLayer(range, expectedLayer);
        }
        
        private static void assertValuesInRangeAreInLayer(IEnumerable<int> range, int expectedLayer)
        {
            foreach (int n in range)
            {
                int result = Day3Calculators.GetLayer(n);
                Assert.True(expectedLayer == result, $"For input:{n} Expected layer:{expectedLayer} but was layer:{result}");
            }
        }
        
        [Fact]
        public void ShouldReturnZerothLayerSizeAs1()
        {
            Assert.Equal(1, Day3Calculators.SizeOfLayer(0));
        }
        
        [Fact]
        public void ShouldReturnFirstLayerSizeAs8()
        {
            Assert.Equal(8, Day3Calculators.SizeOfLayer(1));
        }
        
        [Fact]
        public void ShouldReturnSecondLayerSizeAs16()
        {
            Assert.Equal(16, Day3Calculators.SizeOfLayer(2));
        }
        
        [Fact]
        public void ShouldDoRangeFromXtoY()
        {
            int minSeen = 30;
            int maxSeen = 30;
            
            IEnumerable<int> enumerable = Day3Calculators.Range(23, 37);
            foreach (var i in enumerable)
            {
                if (i < minSeen)
                {
                    minSeen = i;
                } else if (i > maxSeen)
                {
                    maxSeen = i;
                }
            }
            Assert.Equal(23, minSeen);
            Assert.Equal(37, maxSeen);
        }
        
        [Fact]
        public void MaxValueInLayer0_ShouldBe1()
        {
            Assert.Equal(1, Day3Calculators.MaxValueInLayer(0));
        }
        
        [Fact]
        public void MaxValueInLayer1_ShouldBe9()
        {
            Assert.Equal(9, Day3Calculators.MaxValueInLayer(1));
        }
    }
}