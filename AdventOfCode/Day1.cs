using System;
using System.Collections.Generic;

namespace AdventOfCode
{
    public class Day1
    {
        public static int notHuman(string inputCharString)
        {
            var digitList = parseInputToList(inputCharString);
            int runningTotal = 0;

            for (int i = 0; i < digitList.Count; i++)
            {
                if (IsIndexOfLastDigit(i, digitList))
                {
                    if (digitList[i] == digitList[0])
                    {
                        runningTotal += digitList[i];
                    }
                }
                else
                {
                    if (digitList[i] == digitList[i + 1])
                    {
                        runningTotal += digitList[i];
                    }
                }
            }
            return runningTotal;
        }

        private static int HalfwayOffsetIndex(int index, List<int> digitList)
        {
            var size = digitList.Count;
            var rawoffset = index + (size / 2);
            var newIndex = rawoffset >= size ? rawoffset - size : rawoffset;
            return newIndex;
        }

        public static int notHumanHalfwayRound(string input)
        {
            var digitList = parseInputToList(input);
            int runningTotal = 0;

            for (int i = 0; i < digitList.Count; i++)
            {
                if (digitList[i] == digitList[HalfwayOffsetIndex(i, digitList)])
                {
                    runningTotal += digitList[i];
                }
            }
            return runningTotal;
        }

        private static bool IsIndexOfLastDigit(int i, List<int> digitList)
        {
            return i == digitList.Count - 1;
        }

        private static List<int> parseInputToList(String input)
        {
            var parsedList = new List<int>();
            foreach (char digitChar in input)
            {
                parsedList.Add(int.Parse(digitChar.ToString()));
            }
            return parsedList;
        }
    }
}