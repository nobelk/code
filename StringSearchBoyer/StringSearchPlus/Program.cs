using System;
using System.Collections.Generic;

namespace StringSearchPlus
{
    interface StringSearchPlus 
    {
        public IEnumerable<StringMatch> GetStringMatch(string needle, string haystack);
    }

    public class StringMatch
    {
        int start {get; set;}
        int length {get; set;}
    }


    public class StringSearchEngine : StringSearchPlus
    {

        public IEnumerable<StringMatch> GetStringMatch(string needle, string haystack)
        {

            if(string.IsNullOrEmpty(needle) || string.IsNullOrEmpty(haystack))
            {
                throw new ArgumentException("Needle or haystack cannot be empty");
            }

            if(needle.Length > haystack.Length)
            {
                throw new ArgumentException("Needle length is greater than haystack");
            }


            List<StringMatch> stringMatchList = new List<StringMatch>();
            int haystackIndex = 0;
            Dictionary<string, int> matchTable = new Dictionary<string, int>();
            

            for(int index=0; index< needle.Length; index++)
            {
                matchTable.Add(needle[index].ToString(), needle.Length-index-1);
            }

            while(haystackIndex < haystack.Length - needle.Length)
            {
                bool stringMatchFound = true;

                for(int needleIndex=needle.Length-1; needleIndex>=0; needleIndex--)
                {
                    int shiftOffset = 0;
                    if(needle[needleIndex]!=haystack[haystackIndex+needleIndex])
                    {
                        stringMatchFound = false;
                        int match = 0;
                        if(matchTable.TryGetValue(needle[needleIndex].ToString(), out match))
                        {
                            
                        }
                        else
                        {
                            shiftOffset = 
                        }
                        break;
                    }
                }
            }

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
