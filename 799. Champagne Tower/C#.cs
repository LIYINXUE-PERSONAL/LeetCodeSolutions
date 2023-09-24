/*
 * @lc app=leetcode id=799 lang=csharp
 *
 * [799] Champagne Tower
 */

// @lc code=start
public class Solution {
    public double ChampagneTower(int poured, int query_row, int query_glass) {
        double[,] dp = new double[query_row + 2, query_row + 2];
        dp[0,0] = poured;
        for (int i = 0; i <= query_row; i++) {
            for (int j = 0; j <= i; j++) {
                double leak = (dp[i,j] - 1)/2;
                if (leak > 0) {
                    dp[i + 1, j] += leak;
                    dp[i + 1, j + 1] += leak; 
                }
            }
        }

        return Math.Min(1, dp[query_row, query_glass]);
    }
}
// @lc code=end

