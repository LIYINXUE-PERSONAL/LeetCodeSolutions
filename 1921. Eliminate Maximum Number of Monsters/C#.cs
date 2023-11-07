/*
 * @lc app=leetcode id=1921 lang=csharp
 *
 * [1921] Eliminate Maximum Number of Monsters
 */

// @lc code=start
public class Solution {
    public int EliminateMaximum(int[] dist, int[] speed) {
        double[] arrival = new double[dist.Length];
        for (int i = 0; i < dist.Length; i++) {
            arrival[i] = (double)dist[i] / speed[i];
        }
        Array.Sort(arrival);
        int kill = 0;
        for (int i = 0; i < arrival.Length; i++) {
            if (i >= arrival[i]) break;
            kill++;
        }
        return kill;
    }
}
// @lc code=end

