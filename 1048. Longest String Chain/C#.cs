/*
 * @lc app=leetcode id=1048 lang=csharp
 *
 * [1048] Longest String Chain
 */

// @lc code=start
public class Solution {
    public int LongestStrChain(string[] words) {
        Array.Sort(words, (string a, string b) => a.Length.CompareTo(b.Length));
        int n = words.Length, max = 0;
        Dictionary<string, int> dp = new();
        foreach (string word in words) {
            dp[word] = 1;
            for (int i = 0; i < word.Length; i++) {
                string prev = word.Remove(i, 1);
                if (dp.ContainsKey(prev)) dp[word] = Math.Max(dp[word], dp[prev] + 1);
            }
            max = Math.Max(max, dp[word]);
        }
        return max;
    }
}
// @lc code=end

