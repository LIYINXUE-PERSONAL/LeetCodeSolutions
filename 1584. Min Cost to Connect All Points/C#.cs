/*
 * @lc app=leetcode id=1584 lang=csharp
 *
 * [1584] Min Cost to Connect All Points
 */

// @lc code=start
public class Solution {
    public int MinCostConnectPoints(int[][] points) {
        int n = points.Length;
        int result = 0;
        PriorityQueue<int, int> pq = new(); 
        HashSet<int> visited = new();
        pq.Enqueue(0, 0);
        while (visited.Count < n) {
            pq.TryDequeue(out int pointIndex, out int dist);
            if (visited.Contains(pointIndex)) continue;
            visited.Add(pointIndex);
            result += dist;
            for (int nextIndex = 0; nextIndex < n; nextIndex++) {
                if (!visited.Contains(nextIndex)) {
                    int nextDist = Dist(points[pointIndex], points[nextIndex]);
                    pq.Enqueue(nextIndex, nextDist);
                }
            }
        }
        return result;
    }

    private int Dist(int[] x, int[] y) {
        return Math.Abs(y[0] - x[0]) + Math.Abs(y[1] - x[1]);
    }
}
// @lc code=end

