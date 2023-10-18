/*
 * @lc app=leetcode id=2050 lang=csharp
 *
 * [2050] Parallel Courses III
 */

// @lc code=start
public class Solution {
    public int MinimumTime(int n, int[][] relations, int[] time) {
        List<int>[] map = new List<int>[n];
        for (int i = 0; i < n; i++) {
            map[i] = new();
        }
        int[] req = new int[n];
        foreach (int[] relation in relations) {
            int prev = relation[0] - 1, next = relation[1] - 1;
            map[prev].Add(next);
            req[next]++;
        }
        Queue<int> taking = new();
        int[] timeRequired = new int[n];
        for (int i = 0; i < n; i++) {
            if (req[i] == 0) {
                taking.Enqueue(i);
                timeRequired[i] = time[i];
            }
        }
        while (taking.Count > 0) {
            int cur = taking.Dequeue();
            foreach (int next in map[cur]) {
                timeRequired[next] = Math.Max(timeRequired[next], timeRequired[cur] + time[next]);
                if (--req[next] == 0) taking.Enqueue(next);
            }
        }
        return timeRequired.Max();
    }
}
// @lc code=end

