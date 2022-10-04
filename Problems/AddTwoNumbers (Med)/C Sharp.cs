/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
    {
        ListNode Out = new ListNode();
        ListNode ptr = new ListNode(0, Out);
        bool carry = false;
        while(Out!=null)
        {
            if(l1!=null)
            {
                Out.val += l1.val;
                l1 = l1.next;
            }
            if(l2!=null)
            {
                Out.val += l2.val;
                l2 = l2.next;
            }
            if(carry)
                Out.val++;
            carry = false;
            if(Out.val>9)
            {
                Out.val = Out.val%10;
                carry = true;
            }
            Out.next = (l1!=null || l2!=null || carry)? new ListNode():null;
            Out = Out.next;
        }
        Out = ptr.next;
        return Out;
    }
}