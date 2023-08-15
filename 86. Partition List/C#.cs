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
    public ListNode Partition(ListNode head, int x) {
        ListNode h1 = new(), h2 = new(), c1 = h1, c2 = h2, cur = head;
        while (cur != null) {
            if (cur.val < x) {
                c1.next = cur;
                c1 = c1.next;
            }
            else {
                c2.next = cur;
                c2 = c2.next;
            }
            cur = cur.next;
        }
        c1.next = h2.next;
        c2.next = null;
        return h1.next;
    }
}