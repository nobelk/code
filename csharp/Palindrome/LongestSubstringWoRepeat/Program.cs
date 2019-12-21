using System;
using System.Collections.Generic;

namespace LongestSubstringWoRepeat
{
    class Program
    {
        public static int FindLongestSubstringLength(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }

            int longestSubstringLength = 0;
            int tmpLongestSubstringLength = 0;
            int currentLongestSubstringStartIndex = 0;
            Dictionary<string, int> lastSeenIndex = new Dictionary<string, int>();

            int index = 0;
            while (index < input.Length)
            {
                string currentString = input.Substring(index, 1);

                if (lastSeenIndex.ContainsKey(currentString))
                {

                    // if current longest substring index is higher than the current string's index, 
                    // update last seen substring index
                    // then continue to count length
                    if (lastSeenIndex[currentString] < currentLongestSubstringStartIndex)
                    {
                        lastSeenIndex[currentString] = index;
                        tmpLongestSubstringLength++;
                    }

                    // else if this string was seen before, 
                    // restart length counting
                    else
                    {
                        longestSubstringLength = Math.Max(tmpLongestSubstringLength, longestSubstringLength);
                        tmpLongestSubstringLength = 0;
                        currentLongestSubstringStartIndex = lastSeenIndex[currentString] + 1;
                    }
                }
                else
                {
                    lastSeenIndex.Add(currentString, index);
                    tmpLongestSubstringLength++;
                }


                index++;
            }

            return longestSubstringLength;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Program.FindLongestSubstringLength("abcdefghijklmnbcab"));
        }
    }
}
