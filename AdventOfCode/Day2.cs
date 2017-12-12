using System;
using System.Collections.Generic;
using System.Linq;
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

        public static int calculateCheksumUsingOnlyEvenlyDivisibleDigits(string input)
        {
            int runningTotal = 0;
            string[] listOfLines = input.Split('\n');
            foreach (string line in listOfLines)
            {
                runningTotal += FindPairThatDividesEvenlyAndReturnResult(line);
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

        public static bool DivideEvenly(int larger, int smaller)
        {
            return (larger % smaller) == 0;
        }

        public static List<int> Sort(List<int> digitsToSort)
        {
            digitsToSort.Sort();
            digitsToSort.Reverse();
            return digitsToSort;
        }
        
        
        private static int FindPairThatDividesEvenlyAndReturnResult(string oneLineAsString)
        {
            char[] v = new[] {'\t', ' '};
            List<string> listOfStrings = oneLineAsString.Split(v).ToList();
            List<int> listOfInts = new List<int>();
            foreach (string s in listOfStrings)
            {
                listOfInts.Add(int.Parse(s));
            }
            return FindPairThatDividesEvenlyAndReturnResult(listOfInts);
        }

        public static int FindPairThatDividesEvenlyAndReturnResult(List<int> inputLineDigits)
        {
            var sortedList = Sort(inputLineDigits);
            int result = 0;
            
            for (var i = 0; i < sortedList.Count; i++)
            {
                if (!IsLastInList(i, sortedList))
                {
                    result += CheckIfAnySmallerNumbersDivideEvenlyIntoNumberAtIndex_otherwiseZero(i, sortedList);
                }
            }
            return result;
        }

        private static int CheckIfAnySmallerNumbersDivideEvenlyIntoNumberAtIndex_otherwiseZero(int indexofCurrentDigit, List<int> sortedList)
        {
            int result = 0;
            for (int j = indexofCurrentDigit + 1; j < sortedList.Count; j++)
            {
                if (DivideEvenly(sortedList[indexofCurrentDigit], sortedList[j]))
                {
                    result = sortedList[indexofCurrentDigit] / sortedList[j];
                }
            }
            return result;
        }

        private static bool IsLastInList(int i, List<int> sortedList)
        {
            return i >= sortedList.Count;
        }

    }
}