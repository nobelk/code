using System;
using System.Collections.Generic;

namespace SummaryRanges
{
    class Program
    {
	public static IList<string> SummaryRanges(int[] nums)
	{
		IList<string> summary = new List<string>();

		for(int i=0, j=0; j<nums.Length; j++)
		{
			i=j;

			while(j<nums.Length-1 && nums[j+1]==nums[j]+1)
			{
				j++;
			}

			if(i==j)
			{

				summary.Add(i+"");
			}

			else 
			{
				summary.Add(i + "->" + j);
			}
		}

		return summary;
	}


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
