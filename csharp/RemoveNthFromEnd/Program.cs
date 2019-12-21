using System;

namespace RemoveNthFromEnd
{
    public class ListNode
    {
        public int value;
        public ListNode next;

        public ListNode(int value)
        {
            this.value = value;
            next = null;
        }
    }

    class RemoveNthFromEnd
    {


        public ListNode RemoveNthFromEnd(ListNode head, int n) 
        {

            if(head == null || head.next == null)
            {
                return null;
            }

            ListNode start = new ListNode(0);
            start.next = head;
            ListNode slowRunner = start;
            ListNode fastRunner = start;

            int counter=1;
            while(fastRunner.next != null)
            {
                fastRunner = fastRunner.next;

                if(counter < n)
                {
                    counter++;
                }
                else
                {
                    slowRunner = slowRunner.next;
                }
            }

            slowRunner.next = slowRunner.next.next;

            return start.next;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
