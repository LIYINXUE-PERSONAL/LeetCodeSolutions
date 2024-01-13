/*
 * @lc app=leetcode id=1347 lang=csharp
 *
 * [1347] Minimum Number of Steps to Make Two Strings Anagram
 */

// @lc code=start
public class Solution {
    public int MinSteps(string s, string t) {
        int[] freq_s = new int[26], freq_t = new int[26];
        foreach (char c in s) {
            freq_s[c - 'a']++;
        }
        foreach (char c in t) {
            freq_t[c - 'a']++;
        }
        int total = 0;
        for (int i = 0; i < 26; i++) {
            total += Math.Abs(freq_s[i] - freq_t[i]);
        }
        return total / 2;
    }
}
// @lc code=end

