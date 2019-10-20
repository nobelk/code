using System;

namespace SortedArrayToBst
{

    public class TreeNode
    {
        public int value;
        public TreeNode left;
        public TreeNode right;
    }


    class Program
    {
        public static TreeNode ArrayToBst(int[] array, int start, int end)
        {
            if (start < end)
                return null;

            int mid = (start + end) / 2;

            TreeNode node = new TreeNode
            {
                value = array[mid],
                left = ArrayToBst(array, start, mid - 1),
                right = ArrayToBst(array, mid + 1, end)
            };

            return node;
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
