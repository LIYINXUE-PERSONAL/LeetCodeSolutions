/*
 * @lc app=leetcode id=2009 lang=csharp
 *
 * [2009] Minimum Number of Operations to Make Array Continuous
 */

// @lc code=start
public class Solution {
    public int MinOperations(int[] nums) {
        int n = nums.Length;
        int[] dedup = new HashSet<int>(nums).ToArray();
        Array.Sort(dedup);
        int min = nums.Length;
        for (int left = 0, right = 0; left < dedup.Length; left++) {
            while (right < dedup.Length && dedup[right] < dedup[left] + n) {
                right++;
            }
            min = Math.Min(min, n - (right - left));
        }
        return min;
    }
}
// @lc code=end

