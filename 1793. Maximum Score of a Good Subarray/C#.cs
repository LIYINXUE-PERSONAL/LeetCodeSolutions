/*
 * @lc app=leetcode id=1793 lang=csharp
 *
 * [1793] Maximum Score of a Good Subarray
 */

// @lc code=start
public class Solution {
    public int MaximumScore(int[] nums, int k) {
        int n = nums.Length;
        int left = k, right = k;
        int max = nums[k];
        int min = nums[k];
        while (left > 0 || right < n - 1) {
            int minLeft = left > 0 ? nums[left - 1] : 0;
            int minRight = right < n - 1 ? nums[right + 1] : 0;
            if (minLeft < minRight) {
                right++;
                min = Math.Min(min, nums[right]);
            } else {
                left--;
                min = Math.Min(min, nums[left]);
            }
            max = Math.Max(max, min * (right - left + 1));
        }
        return max;
    }
}
// @lc code=end

