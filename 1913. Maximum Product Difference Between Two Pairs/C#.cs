/*
 * @lc app=leetcode id=1913 lang=csharp
 *
 * [1913] Maximum Product Difference Between Two Pairs
 */

// @lc code=start
public class Solution {
    public int MaxProductDifference(int[] nums) {
        Array.Sort(nums);
        return (nums[^1] * nums[^2]) - (nums[0] * nums[1]);
    }
}
// @lc code=end

