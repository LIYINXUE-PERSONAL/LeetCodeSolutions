/*
 * @lc app=leetcode id=1658 lang=csharp
 *
 * [1658] Minimum Operations to Reduce X to Zero
 */

// @lc code=start
public class Solution {
    public int MinOperations(int[] nums, int x) {
        int target = nums.Sum() - x;
        if (target == 0) return nums.Length;
        bool found = false;
        int max = 0, sum = 0, left = 0;
        for (int right = 0; right < nums.Length; right++) {
            sum += nums[right];
            while (left <= right && sum > target) {
                sum -= nums[left++];
            }
            if (sum == target) {
                found = true;
                max = Math.Max(max, right - left + 1);
            }
        }
        return found ? nums.Length - max : -1;
    }
}
// @lc code=end

