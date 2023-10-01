/*
 * @lc app=leetcode id=456 lang=csharp
 *
 * [456] 132 Pattern
 */

// @lc code=start
public class Solution {
    public bool Find132pattern(int[] nums) {
        int num2 = Int32.MinValue;
        Stack<int> stack = new();
        for (int i = nums.Length - 1; i >= 0; i--) {
            if (nums[i] < num2) return true;
            while (stack.Count > 0 && nums[i] > stack.Peek()) {
                num2 = stack.Pop();
            }
            stack.Push(nums[i]);
        }
        return false;
    }
}
// @lc code=end

