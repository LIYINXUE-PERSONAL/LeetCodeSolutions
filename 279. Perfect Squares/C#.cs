/*
 * @lc app=leetcode id=279 lang=csharp
 *
 * [279] Perfect Squares
 */

// @lc code=start
public class Solution {
    public int NumSquares(int n) {
        List<int> squares = new();
        for (int i = 1; true; i++) {
            int square = (int)Math.Pow(i, 2);
            if (square > n) break;
            squares.Add(square);
        }
        int[] dp = Enumerable.Repeat(n, n + 1).ToArray();
        dp[0] = 0;
        for (int i = 1; i <= n; i++) {
            foreach (int square in squares) {
                if (square > i) break;
                dp[i] = Math.Min(dp[i], dp[i - square] + 1);
            }
        }
        return dp[n];
    }
}
// @lc code=end

