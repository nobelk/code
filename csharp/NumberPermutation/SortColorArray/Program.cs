using System;

namespace SortColorArray
{
    public class Solution
    {

        public void SortColors(int[] nums)
        {

            if (nums == null || nums.Length == 0)
            {
                return;
            }

            int lowIndex = 0;
            int highIndex = nums.Length - 1;
            int temp = 0;

            for (int index = lowIndex; index <= highIndex;)
            {

                if (nums[index] < 1)
                {
                    temp = nums[lowIndex];
                    nums[lowIndex] = nums[index];
                    nums[index] = temp;
                    lowIndex++;
                    index++;
                }
                else if (nums[index] > 1)
                {

                    temp = nums[highIndex];
                    nums[highIndex] = nums[index];
                    nums[index] = temp;
                    highIndex--;
                }
                else
                {
                    index++;
                }
            }

            return;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
