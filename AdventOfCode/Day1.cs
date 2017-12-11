using System;

namespace AdventOfCode
{
    public class Day1
    {
        public static int notHuman(string inputCharString)
        {
            int prevDigit = getLastDigit(inputCharString);
            
            int currentDigit = 0;
            int total = 0;
            foreach (char c in inputCharString)
            {
                
                
                currentDigit = int.Parse(c.ToString());
                
                if (prevDigit == currentDigit)
                {
                    total += prevDigit;
                }
                prevDigit = currentDigit;
            }

            return total;
        }

        private static int getLastDigit(string input)
        {
            var lastCharacter = input.Substring(input.Length -1, 1);

            return int.Parse(lastCharacter);
        }
    }
}