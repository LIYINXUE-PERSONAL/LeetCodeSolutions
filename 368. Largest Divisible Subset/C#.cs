/*
 * @lc app=leetcode id=368 lang=csharp
 *
 * [368] Largest Divisible Subset
 */

// @lc code=start
public class Solution {
    public IList<int> LargestDivisibleSubset(int[] nums) {
        Array.Sort(nums);
        int n = nums.Length;
        (int Count, int Prev)[] dp = new (int, int)[n];
        int max = 0;

        for (int i = 0; i < n; i++) {
            dp[i] = (1, -1);
            for (int j = i - 1; j >= 0; j--) {
                if (nums[i] % nums[j] == 0 && dp[i].Count < dp[j].Count + 1) {
                    dp[i] = (dp[j].Count + 1, j);
                }
            }
            if (dp[i].Count > dp[max].Count) max = i;
        }

        List<int> result = new();
        int cur = max;
        while (cur >= 0) {
            result.Add(nums[cur]);
            cur = dp[cur].Prev;
        }
        return result;
    }
}
// @lc code=end

