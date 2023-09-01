/*
 * @lc app=leetcode id=338 lang=csharp
 *
 * [338] Counting Bits
 */

// @lc code=start
public class Solution {
    public int[] CountBits(int n) {
        int[] dp = new int[n + 1];
        for (int i = 1; i <= n; i++) {
            dp[i] = dp[i & (i - 1)] + 1;
        }
        return dp;
    }
}
// @lc code=end

