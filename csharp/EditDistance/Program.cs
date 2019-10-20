using System;

namespace EditDistance
{

    public class Solution
    {
        public int MinDistance(string word1, string word2)
        {
            return editDistance(word1, word2, word1.Length, word2.Length);
        }

        public int editDistance(string word1, string word2, int m, int n)
        {
            if (m == 0)
                return n;

            else if (n == 0)
                return m;

            else if (word1[m - 1] == word2[n - 1])
                return editDistance(word1, word2, m - 1, n - 1);

            else
            {
                return 1 + FindMin(
                    editDistance(word1, word2, m - 1, n),
                    editDistance(word1, word2, m, n - 1),
                    editDistance(word1, word2, m - 1, n - 1)
                );
            }
        }


        public int FindMin(int x, int y, int z)
        {
            return Math.Min(x, Math.Min(y, z));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();

            Console.WriteLine(s.MinDistance("cat","hat"));
        }
    }
}
