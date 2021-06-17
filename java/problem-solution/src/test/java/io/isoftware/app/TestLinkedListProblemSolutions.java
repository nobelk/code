package io.isoftware.app;

import org.junit.Assert;
import org.junit.Test;

public class TestLinkedListProblemSolutions {
    @Test
    public void TestHasCycle(){
        ListNode ln1 = new ListNode(1);
        ListNode ln2 = new ListNode(2);
        ListNode ln3 = new ListNode(3);
        ListNode ln4 = new ListNode(2);
        ListNode ln5 = new ListNode(1);

        ln1.next = ln2;
        ln2.next = ln3;
        ln3.next = ln4;
        ln4.next = ln2;
        ln5.next = null;

        LinkedListProblemSolutions ll = new LinkedListProblemSolutions();
        Assert.assertEquals(true, ll.hasCycle(ln1));
    }

    @Test
    public void TestIsPalindrome(){
        ListNode ln1 = new ListNode(1);
        ListNode ln2 = new ListNode(2);
        ListNode ln3 = new ListNode(3);
        ListNode ln4 = new ListNode(2);
        ListNode ln5 = new ListNode(1);

        ln1.next = ln2;
        ln2.next = ln3;
        ln3.next = ln4;
        ln4.next = ln5;
        ln5.next = null;

        LinkedListProblemSolutions ll = new LinkedListProblemSolutions();
        Assert.assertEquals(true, ll.isPalindrome(ln1));
    }

    @Test
    public void TestSortedMergeLinkedLists() {
        ListNode ln1 = new ListNode(1);
        ListNode ln2 = new ListNode(2);
        ListNode ln3 = new ListNode(3);

        ln1.next = ln2;
        ln2.next = ln3;
        ln3.next = null;

        ListNode ln1_1 = new ListNode(4);
        ListNode ln2_1 = new ListNode(5);
        ListNode ln3_1 = new ListNode(6);

        ln1_1.next = ln2_1;
        ln2_1.next = ln3_1;
        ln3_1.next = null;

        LinkedListProblemSolutions dl = new LinkedListProblemSolutions();
        ListNode head = dl.mergeTwoLists(ln1, ln2);
        Assert.assertEquals(1, head.val);
    }

    @Test
    public void TestReverseList() {
        ListNode ln1 = new ListNode(1);
        ListNode ln2 = new ListNode(2);
        ListNode ln3 = new ListNode(3);

        ln1.next = ln2;
        ln2.next = ln3;
        ln3.next = null;

        LinkedListProblemSolutions dl = new LinkedListProblemSolutions();
        ListNode head = dl.reverseList(ln1);
        Assert.assertEquals(3, head.val);
    }

    @Test
    public void TestDeleteNode(){
        ListNode ln1 = new ListNode(1);
        ListNode ln2 = new ListNode(2);
        ListNode ln3 = new ListNode(3);

        ln1.next = ln2;
        ln2.next = ln3;
        ln3.next = null;

        LinkedListProblemSolutions dl = new LinkedListProblemSolutions();
        dl.deleteNode(ln2);
        Assert.assertEquals(3,ln1.next.val);
    }
}
