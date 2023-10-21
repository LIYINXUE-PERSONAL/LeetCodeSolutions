/*
 * @lc app=leetcode id=1425 lang=csharp
 *
 * [1425] Constrained Subsequence Sum
 */

// @lc code=start
public class Solution {
    public int ConstrainedSubsetSum(int[] nums, int k) {
        LinkedList<int> deque = new();
        for (int i = 0; i < nums.Length; i++) {
            if (deque.Count > 0 && i - deque.First.Value > k) {
                deque.RemoveFirst();
            }
            if (deque.Count > 0) nums[i] += nums[deque.First.Value];
            while (deque.Count > 0 && nums[deque.Last.Value] < nums[i]) {
                deque.RemoveLast();
            }
            if (nums[i] > 0) deque.AddLast(i);
        }
        return nums.Max();
    }
}
// @lc code=end

