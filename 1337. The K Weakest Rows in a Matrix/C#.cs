/*
 * @lc app=leetcode id=1337 lang=csharp
 *
 * [1337] The K Weakest Rows in a Matrix
 */

// @lc code=start
public class Solution {
    public int[] KWeakestRows(int[][] mat, int k) {
        return mat
            .Select((row, index) => new { Index = index, Count = row.Sum()})
            .OrderBy(row => row.Count)
            .ThenBy(row => row.Index)
            .Take(k)
            .Select(row => row.Index)
            .ToArray();
    }
}
// @lc code=end

