/*
 * @lc app=leetcode id=2785 lang=csharp
 *
 * [2785] Sort Vowels in a String
 */

// @lc code=start
public class Solution {
    private HashSet<char> vowels = new() {
        'A', 'a', 'E', 'e', 'I', 'i', 'O', 'o', 'U', 'u'
    };
    private string sortedVowels = "AEIOUaeiou";
    private int[] count = new int[256];

    public string SortVowels(string s) {
        foreach (char c in s) {
            count[c]++;
        }
        StringBuilder result = new();
        int i = 0;
        foreach (char c in s) {
            char n = c;
            if (vowels.Contains(n)) {
                while (count[sortedVowels[i]] == 0) i++;
                n = sortedVowels[i];
                count[sortedVowels[i]]--;
            }
            result.Append(n);
        }
        return result.ToString();
    }
}
// @lc code=end

