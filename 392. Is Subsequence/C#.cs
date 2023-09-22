/*
 * @lc app=leetcode id=392 lang=csharp
 *
 * [392] Is Subsequence
 */

// @lc code=start
public class Solution {
    public bool IsSubsequence(string s, string t) {
        if (s == string.Empty) return true;
        for (int i1 = 0, i2 = 0; i2 < t.Length; i2++) {
            if (t[i2] == s[i1]) i1++;
            if (i1 == s.Length) return true;
        }
        return false;
    }
}
// @lc code=end

