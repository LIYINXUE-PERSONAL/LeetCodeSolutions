/*
 * @lc app=leetcode id=287 lang=csharp
 *
 * [287] Find the Duplicate Number
 */

// @lc code=start
public class Solution {
    public int FindDuplicate(int[] nums) {
        int p1 = nums[0], p2 = nums[0];
        while (true) {
            p1 = nums[p1];
            p2 = nums[nums[p2]];
            if (p1 == p2) break;
        }
        p1 = nums[0];
        while (p1 != p2) {
            p1 = nums[p1];
            p2 = nums[p2];
        }
        return p1;
    }
}
// @lc code=end

