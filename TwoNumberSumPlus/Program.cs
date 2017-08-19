using System;
using System.Collections.Generic;

namespace TwoNumberSumPlus
{
    class Program
    {

        public static int[] FindIndex(int[] inputArray, int sum)
        {
            // validate input
            int[] foundIndex = new int[2];

            // build difference hashtable
            Dictionary<int,int> differenceDictionary = new Dictionary<int, int>();
            for(int index=0; index<inputArray.Length; index++)
            {
                if(!differenceDictionary.ContainsKey(sum-inputArray[index]))
                {
                    differenceDictionary.Add(sum-inputArray[index], index);
                }
            }

            // search for index
            for(int index=0; index<inputArray.Length; index++)
            {
                if(differenceDictionary.ContainsKey(inputArray[index]) 
                &&
                differenceDictionary[inputArray[index]] != index)
                {
                    if(index>differenceDictionary[inputArray[index]])
                    {
                        foundIndex[0]=differenceDictionary[inputArray[index]]+1;
                        foundIndex[1]=index+1;
                        return foundIndex;
                    }
                    else
                    {
                        foundIndex[1]=differenceDictionary[inputArray[index]]+1;
                        foundIndex[0]=index+1;
                        return foundIndex;
                    }
                }
            }

            //return value
            return foundIndex;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] input = new int[] {0, 3, 44, 5, 234, 0, -1, -3, -200, -99, 88};
            int[] indices = Program.FindIndex(input, 87);

            foreach (int index in indices)
            {
                Console.WriteLine(index);
            }
        }
    }
}
