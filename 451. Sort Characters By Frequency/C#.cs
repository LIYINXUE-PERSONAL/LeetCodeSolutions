/*
 * @lc app=leetcode id=451 lang=csharp
 *
 * [451] Sort Characters By Frequency
 */

// @lc code=start
public class Solution {
    public string FrequencySort(string s) {
        Dictionary<char, int> freq = new();
        foreach (char c in s) {
            freq[c] = freq.GetValueOrDefault(c, 0) + 1;
        }
        var descendingFreq = freq.OrderByDescending(x => x.Value);
        StringBuilder result = new();
        foreach (var e in descendingFreq) {
            result.Append(new string(e.Key, e.Value));
        }
        return result.ToString();
    }
}
// @lc code=end

