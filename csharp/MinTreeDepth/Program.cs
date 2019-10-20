using System;

namespace MinTreeDepth
{

    public class TreeNode
    {
        public int value;
        public TreeNode left;
        public TreeNode right;
    }

    class Program
    {
        public static int FindMinDepth(TreeNode node)
        {
            if(node==null) return 0;
            else if(node.left==null) return 1+FindMinDepth(node.right);
            else if(node.right==null) return 1+FindMinDepth(node.left);
            else return 1 + Math.Min(FindMinDepth(node.left), FindMinDepth(node.right));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
