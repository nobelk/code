using System;
using System.Collections.Generic;

namespace PreOrderTreeIter
{

 public class TreeNode {
     public int val;
     public TreeNode left;
     public TreeNode right;
     public TreeNode(int x) { val = x; }
 }



public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        
        // initialize
        List<int> rList = new List<int>();
        Stack<TreeNode> nodeStack = new Stack<TreeNode>();

        // choose first item for stack
        TreeNode currentNode = root;

        // iterate over all items in the stack
        // or over the current non-null item
        while(
            currentNode != null
            ||
            nodeStack.Count > 0
        )
        {
            
            // look at the left part of the tree
            while(currentNode != null)
            {
                nodeStack.Push(currentNode);
                currentNode = currentNode.left;           
            }

            // pop middle node of the leftmost branch
            currentNode = nodeStack.Pop();

            // store value for return
            rList.Add(currentNode.val);

            // look at the right part of the tree
            currentNode = currentNode.right;            
        }

        // return result
        return rList;
     
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
