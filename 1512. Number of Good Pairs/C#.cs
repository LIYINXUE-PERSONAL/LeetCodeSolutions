/*
 * @lc app=leetcode id=1512 lang=csharp
 *
 * [1512] Number of Good Pairs
 */

// @lc code=start
public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        Dictionary<int, int> freq = new();
        int count = 0;
        foreach (int num in nums) {
            if (freq.ContainsKey(num)) {
                count += freq[num];
                freq[num]++;
            }
            else {
                freq[num] = 1;
            }
        }
        return count;
    }
}
// @lc code=end

