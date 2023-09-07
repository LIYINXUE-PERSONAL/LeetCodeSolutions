/*
 * @lc app=leetcode id=92 lang=csharp
 *
 * [92] Reverse Linked List II
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
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        if (left == right) return head;
        ListNode _dummy = new();
        _dummy.next = head;
        ListNode _left = _dummy;
        for (int i = 0; i < left - 1; i++) {
            _left = _left.next;
        }
        ListNode _right = _left.next;
        ListNode _cur = _right.next, _prev = _right;
        for (int i = left; i < right; i++) {
            ListNode _next = _cur.next;
            _cur.next = _prev;
            _prev = _cur;
            _cur = _next;
        }
        _left.next = _prev;
        _right.next = _cur;
        return _dummy.next;
    }
}
// @lc code=end

