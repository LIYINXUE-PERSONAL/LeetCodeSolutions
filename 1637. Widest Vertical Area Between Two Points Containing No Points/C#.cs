/*
 * @lc app=leetcode id=1637 lang=csharp
 *
 * [1637] Widest Vertical Area Between Two Points Containing No Points
 */

// @lc code=start
public class Solution {
    public int MaxWidthOfVerticalArea(int[][] points) {
        int[] x = new int[points.Length];
        for (int i = 0; i < points.Length; i++) {
            x[i] = points[i][0];
        }
        Array.Sort(x);
        int max = 0;
        for (int i = 1; i < points.Length; i++) {
            max = Math.Max(max, x[i] - x[i - 1]);
        }
        return max;
    }
}
// @lc code=end

