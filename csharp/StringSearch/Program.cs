using System;
using System.Collections.Generic;

namespace StringSearch
{

    public class StringMatch
    {
        public int start { get; set; }
        public int length { get; set; }
    }


    public interface IStringSearch
    {

        IEnumerable<StringMatch> Search(string needle, string haystack);
    }

    public class StringSearchImpl : IStringSearch
    {
        public IEnumerable<StringMatch> Search(string needle, string haystack)
        {
            List<StringMatch> searchList = new List<StringMatch>();


            if(string.IsNullOrEmpty(needle)|| string.IsNullOrEmpty(haystack))
            {
                return searchList;
            }

            else if (needle.Length > haystack.Length)
            {
                return searchList;
            }

            for(int haystackIndex =0; haystackIndex < haystack.Length; haystackIndex+=needle.Length)
            {
                bool needleInHaystack = true;
                for(int needleIndex=0; needleIndex<needle.Length; needleIndex++)
                {
                    if(needle[needleIndex]!=haystack[haystackIndex+needleIndex])
                    {
                        needleInHaystack = false;
                        break;
                    }
                }
                if(needleInHaystack)
                {
                    searchList.Add(new StringMatch(){start=haystackIndex, length=needle.Length});
                }
            }

            return searchList;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            StringSearchImpl s = new StringSearchImpl();


            IEnumerable<StringMatch> match =s.Search("ball", "football");
            Console.WriteLine("Complete");
        }
    }
}
