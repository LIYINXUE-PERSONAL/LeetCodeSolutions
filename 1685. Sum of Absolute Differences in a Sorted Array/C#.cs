/*
 * @lc app=leetcode id=1685 lang=csharp
 *
 * [1685] Sum of Absolute Differences in a Sorted Array
 */

// @lc code=start
public class Solution {
    public int[] GetSumAbsoluteDifferences(int[] nums) {
        int n = nums.Length;
        int[] psum = new int[n];
        psum[0] = nums[0];
        for (int i = 1; i < n; i++) {
            psum[i] = psum[i - 1] + nums[i];
        }
        int[] diff = new int[n];
        for (int i = 0; i < n; i++) {
            int left = i > 0 ? nums[i] * i - psum[i - 1] : 0;
            int right = i < n - 1 ? (psum[^1] - psum[i]) - nums[i] * (n - i - 1) : 0;
            diff[i] = left + right;
        }
        return diff;
    }
}
// @lc code=end

