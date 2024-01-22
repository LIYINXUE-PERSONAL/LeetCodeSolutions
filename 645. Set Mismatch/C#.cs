/*
 * @lc app=leetcode id=645 lang=csharp
 *
 * [645] Set Mismatch
 */

// @lc code=start
public class Solution {
    public int[] FindErrorNums(int[] nums) {
        int[] result = new int[2];
        HashSet<int> seen = new();
        foreach (int num in nums) {
            if (seen.Contains(num)) {
                result[0] = num;
                break;
            }
            seen.Add(num);
        }
        int sum = nums.Sum();
        int expected = (1 + nums.Length) * nums.Length / 2;
        result[1] = (result[0] - sum + expected);
        return result;
    }
}
// @lc code=end

