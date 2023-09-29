/*
 * @lc app=leetcode id=896 lang=csharp
 *
 * [896] Monotonic Array
 */

// @lc code=start
public class Solution {
    public bool IsMonotonic(int[] nums) {
        return IsMonotonicIncreasing(nums) || IsMonotonicDecreasing(nums);
    }

    private bool IsMonotonicIncreasing(int[] nums) {
        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] < nums[i - 1]) return false;
        }
        return true;
    }

    private bool IsMonotonicDecreasing(int[] nums) {
        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] > nums[i - 1]) return false;
        }
        return true;
    }
}
// @lc code=end

