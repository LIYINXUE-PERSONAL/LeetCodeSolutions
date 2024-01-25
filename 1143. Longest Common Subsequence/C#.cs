/*
 * @lc app=leetcode id=1143 lang=csharp
 *
 * [1143] Longest Common Subsequence
 */

// @lc code=start
public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {
        int m = text1.Length, n = text2.Length;
        int[,] dp = new int[m + 1, n + 1];
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (text1[i] == text2[j]) dp[i + 1, j + 1] = dp[i,j] + 1;
                else dp[i + 1, j + 1] = Math.Max(dp[i + 1, j], dp[i, j + 1]);
            }
        }
        return dp[m, n];
    }
}
// @lc code=end

