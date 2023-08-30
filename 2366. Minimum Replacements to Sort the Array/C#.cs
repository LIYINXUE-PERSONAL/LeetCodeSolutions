/*
 * @lc app=leetcode id=2366 lang=csharp
 *
 * [2366] Minimum Replacements to Sort the Array
 */

// @lc code=start
public class Solution {
    public long MinimumReplacement(int[] nums) {
        long result = 0;
        for (int i = nums.Length - 2; i >= 0; i--) {
            if (nums[i] > nums[i + 1]) {
                int m = (nums[i] + nums[i + 1] - 1) / nums[i + 1];
                result += m - 1;
                nums[i] = nums[i] / m;
            }
        }
        return result;
    }
}
// @lc code=end

