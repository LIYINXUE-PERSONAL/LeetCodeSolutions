/*
 * @lc app=leetcode id=1582 lang=csharp
 *
 * [1582] Special Positions in a Binary Matrix
 */

// @lc code=start
public class Solution {
    public int NumSpecial(int[][] mat) {
        int[] row = new int[mat.Length], col = new int[mat[0].Length];
        for (int i = 0; i < mat.Length; i++) 
            for (int j = 0; j < mat[0].Length; j++) {
                row[i] += mat[i][j];
                col[j] += mat[i][j];
            }
        int count = 0;
        for (int i = 0; i < mat.Length; i++) 
            if (row[i] == 1) 
                for (int j = 0; j < mat[0].Length; j++) 
                    if (mat[i][j] == 1 && col[j] == 1) count++; 
        return count;
    }
}
// @lc code=end

