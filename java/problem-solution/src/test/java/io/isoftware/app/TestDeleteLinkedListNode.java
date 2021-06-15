package io.isoftware.app;

import org.junit.Assert;
import org.junit.Test;

public class TestDeleteLinkedListNode {

    @Test
    public void Test(){
        ListNode ln1 = new ListNode(1);
        ListNode ln2 = new ListNode(2);
        ListNode ln3 = new ListNode(3);

        ln1.next = ln2;
        ln2.next = ln3;
        ln3.next = null;

        DeleteLinkedListNode dl = new DeleteLinkedListNode();
        dl.deleteNode(ln2);
        Assert.assertEquals(3,ln1.next.val);
    }
}
