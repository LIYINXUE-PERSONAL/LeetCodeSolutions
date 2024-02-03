/*
 * @lc app=leetcode id=1043 lang=csharp
 *
 * [1043] Partition Array for Maximum Sum
 */

// @lc code=start
public class Solution {
    public int MaxSumAfterPartitioning(int[] arr, int k) {
        int[] dp = new int[arr.Length + 1];
        for (int i = 0; i < arr.Length; i++) {
            int max = 0, sum = 0;
            for (int j = i; j > i - k && j >= 0; j--) {
                max = Math.Max(max, arr[j]);
                sum = Math.Max(sum, max * (i - j + 1) + dp[j]);
            }
            dp[i + 1] = sum;
        }
        return dp[^1];
    }
}
// @lc code=end

