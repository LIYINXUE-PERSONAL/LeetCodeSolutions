/*
 * @lc app=leetcode id=746 lang=csharp
 *
 * [746] Min Cost Climbing Stairs
 */

// @lc code=start
public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        for (int i = 2; i < cost.Length; i++) {
            cost[i] += Math.Min(cost[i - 2], cost[i - 1]);
        }
        return Math.Min(cost[^1], cost[^2]);
    }
}
// @lc code=end

