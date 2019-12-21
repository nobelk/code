using System;

namespace Trie
{
    public class Trie
    {
        Trie[] links = new Trie[256];

        public Trie[] Links { 
            get { return links; }
            }

        public bool isLeaf
        {
            get; set;
        }

        public Trie()
        {
            
        }

        public static void Insert(string word, Trie root)
        {
            Trie ct = root;
            for(int index=0; index<word.Length; index++)
            {

                char current = word[index];

                if(ct.Links[(int)current]==null)
                {
                    ct.Links[(int)current] = new Trie();
                    ct = ct.Links[(int)current];
                }
                else
                {
                   ct = ct.Links[(int)current]; 
                }
            }
        }

        public static bool Search(string word, Trie root)
        {

            if(root == null)
            {
                return false;
            }

            else if (string.IsNullOrEmpty(word))
            {
                return false;
            }

            Trie ct = root;
            for(int index=0; index<word.Length; index++)
            {
                if(ct.Links[(int)word[index]] == null)
                {
                    return false;
                }
                else
                {
                    if(index==word.Length-1
                    &&
                    ct.isLeaf)
                    {
                        return true;
                    }
                    ct = ct.Links[(int)word[index]];
                }                
            }

            return false;
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
