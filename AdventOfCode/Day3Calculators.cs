using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode
{
    public class Day3Calculators
    {
        
        public static int GetLayer(int inputNumber)
        {
            if (inputNumber <= 1)
            {
                return 0;
            }

            int currentLayer = 1;
            
            while (true)
            {
                if (MaxValueInLayer(currentLayer) >= inputNumber)
                {
                    return currentLayer;
                }
                currentLayer++;
            }
        }

        public static int MaxValueInLayer(int layerIndex)
        {
            if (layerIndex == 0)
            {
                return 1;
            }

            return (((int)(Math.Pow(layerIndex, 2)) + layerIndex) / 2 * 8) + 1;
        }

        public static int SizeOfLayer(int LayerIndex)
        {
            if (LayerIndex == 0)
            {
                return 1;
            }
            
            return LayerIndex * 8;
        }

        public static IEnumerable<int> Range(int start, int endInclusive)
        {
            return Enumerable.Range(start, endInclusive - (start -1));
        }
    }
}