/*
 * @lc app=leetcode id=1759 lang=csharp
 *
 * [1759] Count Number of Homogenous Substrings
 */

// @lc code=start
public class Solution {
    public int CountHomogenous(string s) {
        long result = 1;
        int count = 1;
        char prev = s[0];
        for (int i = 1; i < s.Length; i++) {
            if (s[i] == prev) count++;
            else {
                count = 1;
                prev = s[i];
            }
            result += count;
        }
        return (int)(result % 1_000_000_007);
    }
}
// @lc code=end

