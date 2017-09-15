using System;
using System.Collections.Generic;

namespace CombinationSum
{
    class Program
    {


        public void Backtrack(bool[] a, int[] candidates, int numberOfValuesSet, List<List<int>> result)
        {
            if(IsAsolution(a, numberOfValuesSet, candidates))
            {
                result.Add(GetSolution(a, candidates));
            }


            bool[] possibleCandidateValues = ConstructCandidates();

            int nextNumberOfValuesSet = numberOfValuesSet+1;

            for(int index=0; index<possibleCandidateValues.Length; index++)
            {
                // make move
                a[nextNumberOfValuesSet-1] = possibleCandidateValues[index];

                // backtrack
                Backtrack(a, candidates, nextNumberOfValuesSet, result);

                // unmake move                
            }
        }



        public bool[] ConstructCandidates()
        {
            bool[] tmp = new bool[2];
            tmp[0] = true;
            tmp[1] = false;

            return tmp;
        }

        public bool IsAsolution(bool[] a, int numberOfValuesSet, int[] candidates)
        {
            return numberOfValuesSet == candidates.Length;
        }

        public List<int> GetSolution(bool[] a, int[] candidates)
        {
            List<int> tmp = new List<int>();

            for(int index=0; index<a.Length; index++)
            {
                if(a[index])
                {
                    tmp.Add(candidates[index]);
                }
            }
            return tmp;
        }

        public IList<IList<int>> CombinationSum(int[] candidates, int target) 
        {
            List<List<int>> result = new List<List<int>>();

            if(candidates == null || candidates.Length==0)
            {
                return (IList<IList<int>>) result;
            }

            else if(candidates.Length==1
            &&
            candidates[0]==target)
            {
                List<int> tmp = new List<int>();
                tmp.Add(candidates[0]);
                result.Add(tmp);
                return  (IList<IList<int>>) result;
            }

            // sort
            Array.Sort(candidates);

            // find Index of elements with value > 7
            int index = 0;
            while(candidates[index]<target)
            {
                index++;   
            }

            // create new solution array
            int[] candidatesTmp = new int[index+1];
            Array.Copy(candidates, candidatesTmp, index+1);
            bool[] a = new bool[index+1];

            Backtrack(a, candidatesTmp, 0, result);

            return (IList<IList<int>>) result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
