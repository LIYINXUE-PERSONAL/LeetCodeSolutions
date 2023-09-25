/*
 * @lc app=leetcode id=389 lang=csharp
 *
 * [389] Find the Difference
 */

// @lc code=start
public class Solution {
    public char FindTheDifference(string s, string t) {
        char b = (char)0;
        foreach (char c in s) {
            b ^= c;
        }
        foreach (char c in t) {
            b ^= c;
        }
        return b;
    }
}
// @lc code=end

