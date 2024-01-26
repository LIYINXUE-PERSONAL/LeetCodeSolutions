/*
 * @lc app=leetcode id=576 lang=csharp
 *
 * [576] Out of Boundary Paths
 */

// @lc code=start
public class Solution {
    private int MOD = 1_000_000_007;

    public int FindPaths(int m, int n, int maxMove, int startRow, int startColumn) {
        int[,] dp = new int[m, n];
        int count = 0;
        dp[startRow, startColumn] = 1;
        for (int k = 0; k < maxMove; k++) {
            int[,] cur = new int[m, n];
            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    if (i == m - 1) AddTo(ref count, dp[i, j]);
                    else AddTo(ref cur[i, j], dp[i + 1, j]);
                    if (j == n - 1) AddTo(ref count, dp[i, j]);
                    else AddTo(ref cur[i, j], dp[i, j + 1]);
                    if (i == 0) AddTo(ref count, dp[i, j]);
                    else AddTo(ref cur[i, j], dp[i - 1, j]);
                    if (j == 0) AddTo(ref count, dp[i, j]);
                    else AddTo(ref cur[i, j], dp[i, j - 1]);
                }
            }
            dp = cur;
        }
        return count;   
    }

    private void AddTo(ref int a, int b) {
        a = (a + b) % MOD;
    }
}
// @lc code=end

