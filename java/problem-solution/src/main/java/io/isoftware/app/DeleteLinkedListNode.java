package io.isoftware.app;

public class DeleteLinkedListNode {

    public void deleteNode(ListNode node) {

        if(node == null){
            return;
        }

        ListNode prev = node;
        while(node.next!=null){
            node.val = node.next.val;
            prev = node;
            node = node.next;
        }

        prev.next = null;
    }
}
