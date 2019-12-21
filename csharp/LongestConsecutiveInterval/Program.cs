using System;
using System.Collections.Generic;

namespace LongestConsecutiveInterval
{

    public class LongestConsecutiveInterval
    {

        public static int LongestConsecutive(int[] nums)
        {

            if(nums==null
            ||
            nums.Length<=1
            )
            {
                return 0;
            }

            Dictionary<int,int> interval = new Dictionary<int,int>();
            int maxIntervalLength = 0;

            foreach(int number in nums)
            {
                if(!interval.ContainsKey(number))
                {
                    int left = interval.ContainsKey(number-1) ? interval[number-1] : 0;
                    int right = interval.ContainsKey(number+1) ? interval[number+1] : 0;

                    int sum = left + right + 1;

                    maxIntervalLength = Math.Max(sum, maxIntervalLength);

                    if(interval.ContainsKey(number-left))
                    {
                        interval[number-left] =  sum;                        
                    }
                    else
                    {
                        interval.Add(number-left, sum);
                    }

                    if(interval.ContainsKey(number+left))
                    {
                        interval[number+left] =  sum;                        
                    }
                    else
                    {
                        interval.Add(number+left, sum);
                    }
                }
                else
                {
                    continue;// duplicate
                }
            }

            return maxIntervalLength;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestConsecutiveInterval.LongestConsecutive(new [] {100, 4, 200, 1, 3, 2}));
        }
    }
}
