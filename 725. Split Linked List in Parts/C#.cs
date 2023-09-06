/*
 * @lc app=leetcode id=725 lang=csharp
 *
 * [725] Split Linked List in Parts
 */

// @lc code=start
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
    public ListNode[] SplitListToParts(ListNode head, int k) {
        ListNode cur = head; 
        int count = 0;
        while (cur != null) {
            cur = cur.next;
            count++;
        }
        ListNode[] result = new ListNode[k];
        cur = head;
        int width = count / k, remainder = count % k;
        for (int i = 0; i < k; i++) {
            result[i] = cur;
            for (int j = 0; j < width + (i < remainder ? 1 : 0) - 1; j++) {
                if (cur != null) cur = cur.next;
            }
            if (cur != null) {
                ListNode prev = cur;
                cur = cur.next;
                prev.next = null;
            }
        }
        return result;
    }
}
// @lc code=end

