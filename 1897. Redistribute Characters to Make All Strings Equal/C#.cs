/*
 * @lc app=leetcode id=1897 lang=csharp
 *
 * [1897] Redistribute Characters to Make All Strings Equal
 */

// @lc code=start
public class Solution {
    public bool MakeEqual(string[] words) {
        int[] freq = new int[26];
        int n = words.Length;
        foreach (string word in words) {
            foreach (char c in word) {
                freq[c - 'a']++;
            }
        }
        foreach (int f in freq) {
            if (f % n != 0) return false;
        }
        return true;
    }
}
// @lc code=end

