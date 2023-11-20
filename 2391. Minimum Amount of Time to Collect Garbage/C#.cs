/*
 * @lc app=leetcode id=2391 lang=csharp
 *
 * [2391] Minimum Amount of Time to Collect Garbage
 */

// @lc code=start
public class Solution {
    public int GarbageCollection(string[] garbage, int[] travel) {
        for (int i = 1; i < travel.Length; i++) {
            travel[i] += travel[i - 1];
        }
        int sum = 0;
        Dictionary<char, int> lastSeen = new();
        for (int i = 0; i < garbage.Length; i++) {
            foreach (char c in garbage[i]) {
                lastSeen[c] = i;
            }
            sum += garbage[i].Length;
        }
        foreach (int last in lastSeen.Values) {
            if (last > 0) sum += travel[last - 1];
        }
        return sum;
    }
}
// @lc code=end

