/*
 * @lc app=leetcode id=62 lang=csharp
 *
 * [62] Unique Paths
 */

// @lc code=start
public class Solution {
    public int UniquePaths(int m, int n) {
        int[] dp = new int[n];
        dp[0] = 1;
        for (int i = 0; i < m; i++) {
            for (int j = 1; j < n; j++) {
                dp[j] += dp[j - 1];
            }
        }
        return dp[^1];
    }

    public int UniquePathsMath(int m, int n) {
        int N = m + n - 2;
        int k = m - 1;

        int result = 1;
        for (int i = 1; i <= k; i++) {
            result *= ((N - k - i) / i);
        }
        return result;
    }
}
// @lc code=end

