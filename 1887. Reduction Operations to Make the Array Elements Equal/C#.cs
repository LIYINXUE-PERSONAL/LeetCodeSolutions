/*
 * @lc app=leetcode id=1887 lang=csharp
 *
 * [1887] Reduction Operations to Make the Array Elements Equal
 */

// @lc code=start
public class Solution {
    public int ReductionOperations(int[] nums) {
        Array.Sort(nums);
        int count = 0, cur = 0;
        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] != nums[i - 1]) cur++;
            count += cur;
        }
        return count;
    }
}
// @lc code=end

