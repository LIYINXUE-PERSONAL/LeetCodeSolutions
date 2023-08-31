/*
 * @lc app=leetcode id=1326 lang=csharp
 *
 * [1326] Minimum Number of Taps to Open to Water a Garden
 */

// @lc code=start
public class Solution {
    public int MinTaps(int n, int[] ranges) {
        int[] dp = new int[n + 1];
        for (int i = 0; i <= n; i++) {
            int left = Math.Max(0, i - ranges[i]);
            int right = Math.Min(n, i + ranges[i]);
            dp[left] = Math.Max(dp[left], right);
        }
        int result = 1, prev = dp[0], cur = dp[0];
        for (int i = 1; i <= n; i++) {
            if (i > cur) return -1;
            if (i > prev) {
                result++;
                prev = cur;
            }
            cur = Math.Max(cur, dp[i]);
        }
        return result;
    }
}
// @lc code=end

