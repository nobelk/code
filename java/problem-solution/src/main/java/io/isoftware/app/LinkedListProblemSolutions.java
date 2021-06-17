package io.isoftware.app;

import java.util.HashSet;
import java.util.Set;
import java.util.Stack;

public class LinkedListProblemSolutions {

    public boolean hasCycle(ListNode head){
        Set<ListNode> nodeSet = new HashSet<>();
        ListNode curr = head;
        while(curr!=null){
            if(nodeSet.contains(curr)){
                return true;
            }

            nodeSet.add(curr);
            curr = curr.next;
        }

        return false;
    }

    public boolean isPalindrome(ListNode head) {
        Stack<Integer> valueStack = new Stack<>();
        ListNode curr = head;
        int length = 0;
        while(curr!=null){
            valueStack.push(curr.val);
            curr = curr.next;
            length++;
        }

        int currLength = 0;
        curr = head;
        while(curr!=null){
            currLength++;
            if(currLength == length/2 + 1){
                continue;
            }
            int currentValue = valueStack.pop();
            if(curr.val!=currentValue){
                return false;
            }

            curr = curr.next;
        }

        return true;
    }

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

    public ListNode reverseList(ListNode head) {

        ListNode prev = null;
        ListNode current = head;
        while(current != null){

            ListNode tmp = current.next;
            current.next = prev;

            prev = current;
            current = tmp;
        }
        return prev;
    }

    public ListNode mergeTwoLists(ListNode l1, ListNode l2) {
        if(l1==null){
            return l2;
        }

        if(l2==null){
            return l1;
        }

        if(l1==null && l2==null){
            return null;
        }

        if(l1.val<l2.val){
            l1.next = mergeTwoLists(l1.next, l2);
            return l1;
        }
        else{
            l2.next = mergeTwoLists(l1, l2.next);
            return l2;
        }
    }

    public ListNode removeNthFromEnd(ListNode head, int n) {

        ListNode dummy = new ListNode(0);
        dummy.next = head;
        ListNode first = dummy;
        ListNode second = dummy;

        for(int counter = 1; counter<=n+1; counter++){
            first = first.next;
        }

        while(first!=null){
            first = first.next;
            second = second.next;
        }

        second.next = second.next.next;

        return dummy.next;
    }
}
