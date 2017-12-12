using System;
using System.Runtime.CompilerServices;

namespace AdventOfCode
{
    public class Day2
    {
        public static int calculateCheksum(String input)
        {
            int runningTotal = 0;
            string[] listOfLines = input.Split('\n');
            foreach (string line in listOfLines)
            {
                runningTotal += differenceBetweenLargestAndSmallest(line);
            }
            return runningTotal;
        }

        public static int differenceBetweenLargestAndSmallest(String oneRowInput)
        {
            char[] v = new[] {'\t', ' '};
            string[] strings = oneRowInput.Split(v);
            int currentHighest = 0;
            int currentLowest = int.MaxValue;

            for (var i = 0; i < strings.Length; i++)
            {
                string numberString = strings[i];
                int currentValue = int.Parse(numberString);

                if (currentValue < currentLowest)
                {
                    currentLowest = currentValue;
                }

                if (currentValue > currentHighest)
                {
                    currentHighest = currentValue;
                }
            }
            return currentHighest - currentLowest;
        }
    }
}