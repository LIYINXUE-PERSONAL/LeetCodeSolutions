/*
 * @lc app=leetcode id=1980 lang=csharp
 *
 * [1980] Find Unique Binary String
 */

// @lc code=start
public class Solution {
    public string FindDifferentBinaryString(string[] nums) {
        StringBuilder result = new();
        for (int i = 0; i < nums.Length; i++) {
            result.Append(nums[i][i] == '0' ? '1' : '0');
        }
        return result.ToString();
    }
}
// @lc code=end

