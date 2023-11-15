/*
 * @lc app=leetcode id=1930 lang=csharp
 *
 * [1930] Unique Length-3 Palindromic Subsequences
 */

// @lc code=start
public class Solution {
    public int CountPalindromicSubsequence(string s) {
        HashSet<char> charList = new(s.ToCharArray());
        int result = 0;
        foreach (char c in charList) {
            int first = s.IndexOf(c);
            int last = s.LastIndexOf(c);
            if (first == last) continue;
            HashSet<char> middle = new();
            for (int i = first + 1; i < last; i++) {
                middle.Add(s[i]);
            }
            result += middle.Count;
        }
        return result;
    }
}
// @lc code=end

