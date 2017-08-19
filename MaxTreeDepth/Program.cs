using System;

namespace MaxTreeDepth
{

    public class TreeNode 
    {
        public int value;
        public TreeNode left;
        public TreeNode right;



    }


    class Program
    {

        public static int GetMaxHeight(TreeNode node)
        {
            if(node==null)
            {
                return 0;
            }

            return (1+ Math.Max(
                GetMaxHeight(node.left),
                GetMaxHeight(node.right)
            ));
        }


        static void Main(string[] args)
        {
            Console.WriteLine(GetMaxHeight(null));
        }
    }
}
