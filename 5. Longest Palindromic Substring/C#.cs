/*
 * @lc app=leetcode id=5 lang=csharp
 *
 * [5] Longest Palindromic Substring
 */

// @lc code=start
public class Solution {
    public string LongestPalindrome(string s) {
        string max = $"{s[0]}";
        bool[,] dp = new bool[s.Length, s.Length];
        for (int i = 0; i < s.Length; i++) {
            dp[i,i] = true;
        }
        for (int r = 1; r < s.Length; r++) {
            for (int l = 0; l < r; l++) {
                dp[l,r] = (s[l] == s[r]) && (dp[l + 1, r - 1] || r - l == 1);
                int len = r - l + 1;
                if (dp[l,r] && len > max.Length) {
                    max = s.Substring(l, len);
                }
            }
        }
        return max;
    }
}
// @lc code=end

