/*
 * @lc app=leetcode id=2482 lang=csharp
 *
 * [2482] Difference Between Ones and Zeros in Row and Column
 */

// @lc code=start
public class Solution {
    public int[][] OnesMinusZeros(int[][] grid) {
        int m = grid.Length, n = grid[0].Length;
        int[] onesRow = new int[m];
        int[] onesCol = new int[n];
        for (int i = 0; i < m; i++) 
            for (int j = 0; j < n; j++) {
                onesRow[i] += grid[i][j];
                onesCol[j] += grid[i][j];
            }
        int[][] result = new int[m][];
        for (int i = 0; i < m; i++) {
            result[i] = new int[n];
            for (int j = 0; j < n; j++) {
                result[i][j] = ((onesRow[i] + onesCol[j]) << 1) - m - n;
            }
        }
        return result;
    }
}
// @lc code=end

