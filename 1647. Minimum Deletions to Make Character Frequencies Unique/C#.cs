/*
 * @lc app=leetcode id=1647 lang=csharp
 *
 * [1647] Minimum Deletions to Make Character Frequencies Unique
 */

// @lc code=start
public class Solution {
    public int MinDeletions(string s) {
        int[] freq = new int[26];
        foreach (char c in s) {
            freq[c-'a']++;
        }
        HashSet<int> seen = new();
        int del = 0;
        for (int i = 0; i < 26; i++) {
            int f = freq[i];
            while (f > 0 && seen.Contains(f)) {
                f--;
                del++;
            }
            seen.Add(f);
        }
        return del;
    }
}
// @lc code=end

