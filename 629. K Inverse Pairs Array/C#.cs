/*
 * @lc app=leetcode id=629 lang=csharp
 *
 * [629] K Inverse Pairs Array
 */

// @lc code=start
public class Solution {
    private int MOD = 1_000_000_007;

    public int KInversePairs(int n, int k) {
        int[] dp = new int[k + 1];
        dp[0] = 1;
        for (int i = 1; i <= n; i++) {
            int[] cur = new int[k + 1];
            cur[0] = 1;
            for (int j = 1; j <= k; j++) {
                cur[j] = dp[j] + cur[j - 1];
                if (j >= i) cur[j] -= dp[j - i];
                if (cur[j] < 0) cur[j] += MOD;
                cur[j] = cur[j] % MOD;
            }
            dp = cur;
        }
        return dp[k];
    }
}
// @lc code=end

