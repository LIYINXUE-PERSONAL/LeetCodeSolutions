/*
 * @lc app=leetcode id=446 lang=csharp
 *
 * [446] Arithmetic Slices II - Subsequence
 */

// @lc code=start
public class Solution {
    public int NumberOfArithmeticSlices(int[] nums) {
        int result = 0;
        Dictionary<int, int>[] dp = new Dictionary<int, int>[nums.Length];
        for (int i = 0; i < nums.Length; i++) {
            dp[i] = new();
            for (int j = 0; j < i; j++) {
                long diff = (long)nums[i] - (long)nums[j];
                if (diff >= Int32.MaxValue || diff <= Int32.MinValue) continue;
                int d = (int)diff;
                dp[i][d] = dp[i].GetValueOrDefault(d) + 1;
                if (dp[j].ContainsKey(d)) {
                    dp[i][d] += dp[j][d];
                    result += dp[j][d];
                }
            }
        }
        return result;
    }
}
}
// @lc code=end

