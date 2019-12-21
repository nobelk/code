using System;

namespace IsValidBST
{


    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public class Solution
    {
        public bool IsValidBST(TreeNode root)
        {

            if (root == null)
                return true;

            List<int> nodeList = new List<int>();

            InOrderCheck(root, nodeList);

            for (int index = 1; index < nodeList.Count; index++)
            {
                if (nodeList[index] < nodeList[index - 1])
                    return false;
            }

            return true;
        }


        public void InOrderCheck(TreeNode root, List<int> nodeList)
        {
            if (root == null)
                return;

            InOrderCheck(root.left, nodeList);

            nodeList.Add(root.val);

            InOrderCheck(root.right, nodeList);
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
