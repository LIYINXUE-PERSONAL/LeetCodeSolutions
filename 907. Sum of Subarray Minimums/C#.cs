/*
 * @lc app=leetcode id=907 lang=csharp
 *
 * [907] Sum of Subarray Minimums
 */

// @lc code=start
public class Solution {
    private int MOD = 1_000_000_007;
    public int SumSubarrayMins(int[] arr) {
        int[] dp = new int[arr.Length];
        Stack<int> stack = new();

        for (int i = 0; i < arr.Length; i++) {
            while (stack.Count > 0 && arr[stack.Peek()] >= arr[i]) stack.Pop();
            if (stack.Count > 0) {
                dp[i] = arr[i] * (i - stack.Peek()) + dp[stack.Peek()];
            }
            else {
                dp[i] = arr[i] * (i + 1);
            }
            stack.Push(i);
        }

        long sum = 0;
        foreach (int n in dp) {
            sum += n;
            sum %= MOD;
        }
        return (int)sum;
    }
}
// @lc code=end

