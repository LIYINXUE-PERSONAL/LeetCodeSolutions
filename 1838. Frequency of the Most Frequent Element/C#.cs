/*
 * @lc app=leetcode id=1838 lang=csharp
 *
 * [1838] Frequency of the Most Frequent Element
 */

// @lc code=start
public class Solution {
    public int MaxFrequency(int[] nums, int k) {
        Array.Sort(nums);
        int max = 0, sum = 0;
        for (int left = 0, right = 0; right < nums.Length; right++) {
            sum += nums[right];
            while ((right - left + 1) * nums[right] - sum > k) {
                sum -= nums[left];
                left++;
            }
            max = Math.Max(max, right - left + 1);
        }
        return max;
    }
}
// @lc code=end

