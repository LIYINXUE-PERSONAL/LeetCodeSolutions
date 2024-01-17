/*
 * @lc app=leetcode id=1207 lang=csharp
 *
 * [1207] Unique Number of Occurrences
 */

// @lc code=start
public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        Dictionary<int, int> freq = new();
        foreach (int n in arr) {
            freq[n] = freq.GetValueOrDefault(n, 0) + 1;
        }
        HashSet<int> oc = new(freq.Values);
        return oc.Count == freq.Count;
    }
}
// @lc code=end

