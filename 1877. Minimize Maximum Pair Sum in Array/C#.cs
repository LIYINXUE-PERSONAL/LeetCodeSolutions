/*
 * @lc app=leetcode id=1877 lang=csharp
 *
 * [1877] Minimize Maximum Pair Sum in Array
 */

// @lc code=start
public class Solution {
    public int MinPairSum(int[] nums) {
        Array.Sort(nums);
        int max = 0;
        for (int i = 0; i < nums.Length / 2; i++) {
            max = Math.Max(max, nums[i] + nums[nums.Length - i - 1]);
        }
        return max;
    }
}
// @lc code=end

