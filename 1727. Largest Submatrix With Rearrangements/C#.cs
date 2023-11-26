/*
 * @lc app=leetcode id=1727 lang=csharp
 *
 * [1727] Largest Submatrix With Rearrangements
 */

// @lc code=start
public class Solution {
    public int LargestSubmatrix(int[][] matrix) {
        int m = matrix.Length, n = matrix[0].Length;
        for (int i = 1; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (matrix[i][j] > 0) {
                    matrix[i][j] += matrix[i - 1][j];
                }
            }
        }
        int max = 0;
        for (int i = 0; i < m; i++) {
            int[] sorted = (int[])matrix[i].Clone();
            Array.Sort(sorted);
            for (int j = 0; j < n; j++) {
                max = Math.Max(max, sorted[j] * (n - j));
            }
        }
        return max;
    }
}
// @lc code=end

