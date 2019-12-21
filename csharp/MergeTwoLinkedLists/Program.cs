using System;

namespace MergeTwoLinkedLists
{

    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
    }

    public class LinkedList
    {
        public Node Head { get; set; }
    }





    class Program
    {

        public static Node MergeTwoSortedLinkedLists(LinkedList l1, LinkedList l2)
        {
            Node dummyNode = new Node();

            // check l1/l2 size

            Node l1Node = l1.Head;
            Node l2Node = l2.Head;
            Node currentNode = null;
            if (l1Node.Value < l2Node.Value)
            {
                dummyNode.Next = l1Node;
                currentNode = l1Node;
                l1Node = l1Node.Next;
            }
            else
            {
                dummyNode.Next = l2Node;
                currentNode = l2Node;
                l2Node = l2Node.Next;
            }

            while (
                l1Node != null
                &&
                l2Node != null
            )
            {
                if (l1Node.Value < l2Node.Value)
                {
                    currentNode.Next = l1Node;
                    l1Node = l1Node.Next;
                }
                else
                {
                    currentNode.Next = l2Node;
                    l2Node = l2Node.Next;
                }

                currentNode = currentNode.Next;
            }

            if (l1Node != null)
            {
                currentNode.Next = l1Node;
            }
            if (l2Node != null)
            {
                currentNode.Next = l2Node;
            }

            return dummyNode.Next;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
