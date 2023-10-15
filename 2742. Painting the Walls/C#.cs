/*
 * @lc app=leetcode id=2742 lang=csharp
 *
 * [2742] Painting the Walls
 */

// @lc code=start
public class Solution {
    private int[,] memo;
    private int n;
    private int[] cost, time;

    public int PaintWalls(int[] cost, int[] time) {
        this.cost = cost;
        this.time = time;
        this.n = cost.Length;
        memo = new int[n, n + 1];
        return MinCostAt(0, n); 
    }
    
    private int MinCostAt(int cur, int remain) {
        if (remain <= 0) return 0;
        if (cur >= n) return Int32.MaxValue / 2;
        if (memo[cur, remain] > 0) return memo[cur, remain];
        int work = cost[cur] + MinCostAt(cur + 1, remain - 1 - time[cur]);
        int skip = MinCostAt(cur + 1, remain);
        return memo[cur, remain] = Math.Min(work, skip);
    }
}
// @lc code=end

