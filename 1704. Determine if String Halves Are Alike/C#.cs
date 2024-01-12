/*
 * @lc app=leetcode id=1704 lang=csharp
 *
 * [1704] Determine if String Halves Are Alike
 */

// @lc code=start
public class Solution {
    private char[] vowel_list = {'a','e','i','o','u','A','E','I','O','U'};

    public bool HalvesAreAlike(string s) {
        HashSet<char> vowels = new(vowel_list);
        int left = 0, right = s.Length - 1;
        int h1 = 0, h2 = 0;
        while (left < right) {
            if (vowels.Contains(s[left++])) h1++;
            if (vowels.Contains(s[right--])) h2++;
        }
        return h1 == h2;
    }
}
// @lc code=end

