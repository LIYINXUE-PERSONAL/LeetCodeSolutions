/*
 * @lc app=leetcode id=739 lang=csharp
 *
 * [739] Daily Temperatures
 */

// @lc code=start
public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[] result = new int[temperatures.Length];
        Stack<int> stack = new();
        for (int i = temperatures.Length - 1; i >= 0; i--) {
            while (stack.Count > 0 && temperatures[i] >= temperatures[stack.Peek()]) {
                stack.Pop();
            }
            if (stack.Count > 0) result[i] = stack.Peek() - i;
            stack.Push(i);
        }
        return result;
    }
}
// @lc code=end

