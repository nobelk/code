using System;

namespace MoveZeroes
{

    /**
    Given an array nums, write a function to move all 0's to the end of it while maintaining the relative order of the non-zero elements.

    For example, given nums = [0, 1, 0, 3, 12], after calling your function, nums should be [1, 3, 12, 0, 0].
     */

    public class Solution {
    public void MoveZeroes(int[] nums) {
    
        for(int lastNonZeorElementIndex=0, cur=0; cur<nums.Length; cur++)
        {
            if(nums[cur]!=0)
            {
                swap(nums, lastNonZeorElementIndex, cur);
                lastNonZeorElementIndex++;
            }
        }   
        
    }
    
    
    public void swap(int[] nums, int i, int j)
    {
        int tmp = nums[j];
        nums[j] =  nums[i];
        nums[i] =  tmp;
    }
}

    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] {0, 1, 2, 1, 3};
            Solution s = new Solution();
           s.MoveZeroes(nums);

           foreach(int num in nums)
           {
               Console.Write(num + " ");
           }
        }
    }
}
