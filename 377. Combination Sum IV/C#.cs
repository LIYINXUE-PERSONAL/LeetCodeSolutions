/*
 * @lc app=leetcode id=377 lang=csharp
 *
 * [377] Combination Sum IV
 */

// @lc code=start
public class Solution {
    public int CombinationSum4(int[] nums, int target) {
        Array.Sort(nums);
        int[] dp = new int[target + 1];
        dp[0] = 1;
        for (int i = 1; i <= target; i++) {
            for (int j = 0; j < nums.Length && nums[j] <= i; j++) {
                dp[i] += dp[i - nums[j]];
            }
        }
        return dp[^1];
    }
}
// @lc code=end

