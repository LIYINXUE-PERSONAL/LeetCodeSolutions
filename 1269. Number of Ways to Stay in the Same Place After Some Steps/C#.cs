/*
 * @lc app=leetcode id=1269 lang=csharp
 *
 * [1269] Number of Ways to Stay in the Same Place After Some Steps
 */

// @lc code=start
public class Solution {
    private int[,] memo;
    private int MOD = 1_000_000_007;
    private int arrLen;

    public int NumWays(int steps, int arrLen) {
        this.arrLen = Math.Min(steps, arrLen);
        memo = new int[this.arrLen, steps + 1];
        for (int i = 0; i < this.arrLen; i++) {
            for (int j = 0; j <= steps; j++) {
                memo[i,j] = -1;
            }
        }
        return FindWaysAt(0, steps);
    }

    private int FindWaysAt(int pos, int steps) {
        if (steps == 0) {
            return pos == 0 ? 1 : 0;
        }
        if (memo[pos, steps] >= 0) return memo[pos, steps];
        long total = FindWaysAt(pos, steps - 1);
        if (pos > 0) {
            total += FindWaysAt(pos - 1, steps - 1);
        }
        if (pos < arrLen - 1) {
            total += FindWaysAt(pos + 1, steps - 1);
        }
        return memo[pos, steps] = (int)(total % MOD);
    }
}
// @lc code=end

