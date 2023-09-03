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
        return (int)Combination(m + n - 2, m - 1);
    }
    public BigInteger Combination(int n, int r)
    {
        return Factorial(n) / (Factorial(r) * Factorial(n - r));
    }
    private BigInteger Factorial(int num) {
        BigInteger result = 1;
        for (int i = 1; i <= num; i++) {
            result *= i;
        }
        return result;
    }
}
// @lc code=end

