/*
 * @lc app=leetcode id=880 lang=csharp
 *
 * [880] Decoded String at Index
 */

// @lc code=start
public class Solution {
    public string DecodeAtIndex(string s, int k) {
        long len = 0;
        int i = 0;
        for (i = 0; len < k; i++) {
            if (Char.IsDigit(s[i])) {
                len *= (int)Char.GetNumericValue(s[i]);
            }
            else {
                len++;
            }
        }
        while (i-->0) {
            if (Char.IsDigit(s[i])) {
                len /= (int)Char.GetNumericValue(s[i]);
                k %= (int)len;
            }
            else if (k % len-- == 0) {
                return s[i].ToString();
            }
        }
        return string.Empty;
    }
}
// @lc code=end

