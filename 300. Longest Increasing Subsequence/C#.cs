/*
 * @lc app=leetcode id=300 lang=csharp
 *
 * [300] Longest Increasing Subsequence
 */

// @lc code=start
public class Solution {
    public int LengthOfLIS(int[] nums) {
        int[] dp = Enumerable.Repeat(1, nums.Length).ToArray();
        for (int i = 1; i < nums.Length; i++) {
            for (int j = 0; j < i; j++) {
                if (nums[i] > nums[j]) {
                    dp[i] = Math.Max(dp[i], dp[j] + 1);
                }
            }
        }
        return dp.Max();
    }
}
// @lc code=end

