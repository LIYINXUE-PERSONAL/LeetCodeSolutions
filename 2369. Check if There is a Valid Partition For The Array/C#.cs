public class Solution {
    public bool ValidPartition(int[] nums) {
        bool[] dp = new bool[nums.Length + 1];
        dp[0] = true;
        for (int i = 0; i < nums.Length; i++) {
            if (i > 0 && nums[i] == nums[i - 1]) {
                dp[i + 1] |= dp[i - 1];
            }
            if (i > 1 && nums[i] == nums[i - 1] && nums[i] == nums[i - 2]) {
                dp[i + 1] |= dp [i - 2];
            }
            if (i > 1 && nums[i] == nums[i - 1] + 1 && nums[i - 1] == nums[i - 2] + 1) {
                dp[i + 1] |= dp[i - 2];
            }
        }
        return dp[^1];
    }
}