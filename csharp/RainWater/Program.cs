using System;
using System.Collections.Generic;

namespace RainWater
{

    public class RainWater
    {

        public static int Trap(int[] height)
        {
            //consider boundary condition
            if(height==null 
            ||
            height.Length<=2)
            {
                return 0;
            }

            // initialize var
            int totalVolume = 0;
            Dictionary<int,int> leftMax = new Dictionary<int,int>();
            Dictionary<int,int> rightMax = new Dictionary<int,int>();


            // calculate left max height for each element
            // starting from the second element
            leftMax.Add(0, height[0]);
            for(int index=1; index<height.Length; index++)
            {
                /** Mistake #1: not considering the dynamic property */
                leftMax.Add(index, Math.Max(leftMax[index-1], height[index]));
            }


            // calculate right max height for each element
            // starting from the one element before the last
            rightMax.Add(height.Length-1, height[height.Length-1]);
            for(int index=height.Length-2; index>=0; index--)
            {
                /** Mistake #2: not considering the dynamic property */
                rightMax.Add(index, Math.Max(rightMax[index+1], height[index]));
            }

            // for each element compare left max height and
            // right max height to add to the total volume of
            // rain water
            for(int index=1; index<height.Length-1; index++)
            {
                int currentVolume = Math.Min(leftMax[index], rightMax[index])-height[index];
                Console.Write("Current vol: " + currentVolume);

                /** Mistake #3: using tri operator ? */
                
                totalVolume += Math.Min(leftMax[index], rightMax[index])-height[index] ; 

                /** Mistake #4: not subtracting special case */

                Console.Write(" Total: "+totalVolume+"\n");            
            }

            // return result
            return totalVolume;

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] height = {0,1,0,2,1,0,1,3,2,1,2,1};
            Console.WriteLine(RainWater.Trap(height));
        }
    }
}
