/*
 * @lc app=leetcode id=1160 lang=csharp
 *
 * [1160] Find Words That Can Be Formed by Characters
 */

// @lc code=start
public class Solution {
    public int CountCharacters(string[] words, string chars) {
        char[] dict = new char[26];
        foreach (char c in chars) {
            dict[c - 'a']++;
        }
        int count = 0;
        foreach (string word in words) {
            bool good = true;
            char[] cur = new char[26];
            foreach (char c in word) {
                cur[c - 'a']++;
                if (cur[c - 'a'] > dict[c - 'a']) {
                    good = false;
                    break;
                }
            }
            if (good) count += word.Length;
        }
        return count;
    }
}
// @lc code=end

