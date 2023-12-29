/*
 * @lc app=leetcode id=1335 lang=csharp
 *
 * [1335] Minimum Difficulty of a Job Schedule
 */

// @lc code=start
public class Solution {
    public int MinDifficulty(int[] jobDifficulty, int d) {
        int n = jobDifficulty.Length;
        if (n < d) return -1;
        int?[,] dp = new int?[n + 1, d + 1]; 
        dp[0,0] = 0;
        for (int i = 1; i <= n; i++) {
            for (int j = 1; j <= d; j++) {
                int curMax = 0;
                for (int k = i - 1; k >= j - 1; k--) {
                    curMax = Math.Max(curMax, jobDifficulty[k]);
                    if (dp[k,j-1] != null) {
                        int curDiff = dp[k, j - 1].Value + curMax;
                        if (dp[i,j] == null) dp[i,j] = curDiff;
                        else dp[i,j] = Math.Min(dp[i,j].Value, curDiff);
                    }
                }
            }
        }
        return dp[n,d].Value;
    }
}
// @lc code=end

