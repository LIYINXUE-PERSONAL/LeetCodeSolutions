/*
 * @lc app=leetcode id=931 lang=csharp
 *
 * [931] Minimum Falling Path Sum
 */

// @lc code=start
public class Solution {
    public int MinFallingPathSum(int[][] matrix) {
        for (int i = 1; i < matrix.Length; i++) {
            for (int j = 0; j < matrix[i].Length; j++) {
                List<int> cur = new();
                if (j > 0) cur.Add(matrix[i - 1][j - 1]);
                cur.Add(matrix[i - 1][j]);
                if (j < matrix[i].Length - 1) cur.Add(matrix[i - 1][j + 1]);
                matrix[i][j] += cur.Min();
            }
        }
        return matrix[^1].Min();
    }
}
// @lc code=end

