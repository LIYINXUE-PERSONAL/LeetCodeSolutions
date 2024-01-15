/*
 * @lc app=leetcode id=1657 lang=csharp
 *
 * [1657] Determine if Two Strings Are Close
 */

// @lc code=start
public class Solution {
    public bool CloseStrings(string word1, string word2) {
        if (word1.Length != word2.Length) return false;

        int[] freq1 = new int[26], freq2 = new int[26];
        HashSet<char> char1 = new(), char2 = new();

        for (int i = 0; i < word1.Length; i++) {
            freq1[word1[i] - 'a']++;
            freq2[word2[i] - 'a']++;
            char1.Add(word1[i]);
            char2.Add(word2[i]);
        }

        Array.Sort(freq1);
        Array.Sort(freq2);
        
        return freq1.SequenceEqual(freq2) && char1.SetEquals(char2);
    }
}
// @lc code=end

