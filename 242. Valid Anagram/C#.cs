/*
 * @lc app=leetcode id=242 lang=csharp
 *
 * [242] Valid Anagram
 */

// @lc code=start
public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] s_count = new int[26], t_count = new int[26];
        foreach (char c in s) {
            s_count[c - 'a']++;
        }
        foreach (char c in t) {
            t_count[c - 'a']++;
        }
        for (int i = 0; i < 26; i++) {
            if (s_count[i] != t_count[i]) return false;
        }
        return true;
    }
}
// @lc code=end

