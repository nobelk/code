using System;
using System.Collections.Generic;

namespace LevelOrderTraversal
{

    //Definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public class Solution
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {

            IList<IList<int>> mainList = new List<IList<int>>();
            if (root == null)
            {
                return mainList;
            }

            Queue<TreeNode> nodeQueue = new Queue<TreeNode>();
            nodeQueue.Enqueue(root);

            while (nodeQueue.Count > 0)
            {
                int count = nodeQueue.Count;
                IList<int> subList = new List<int>();

                for (int counter = 0; counter < count; counter++)
                {
                    TreeNode node = nodeQueue.Dequeue();
                    subList.Add(node.val);

                    if (node.left != null)
                    {
                        nodeQueue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        nodeQueue.Enqueue(node.right);
                    }
                }

                mainList.Add(subList);

            }

            return mainList;
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
