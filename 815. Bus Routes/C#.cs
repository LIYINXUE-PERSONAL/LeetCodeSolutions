/*
 * @lc app=leetcode id=815 lang=csharp
 *
 * [815] Bus Routes
 */

// @lc code=start
public class Solution {
    public int NumBusesToDestination(int[][] routes, int source, int target) {
        if (source == target) return 0;
        Dictionary<int, List<int>> map = new();
        for (int i = 0; i < routes.Length; i++) {
            foreach (int station in routes[i]) {
                if (!map.ContainsKey(station)) map[station] = new();
                map[station].Add(i);
            }
        }
        HashSet<int> taken = new();
        Queue<int> taking = new();
        foreach (int route in map[source]) {
            taking.Enqueue(route);
            taken.Add(route);
        }
        int change = 0;
        while (taking.Count > 0) {
            int count = taking.Count;
            while (count --> 0) {
                int route = taking.Dequeue();
                foreach (int station in routes[route]) {
                    if (station == target) return change + 1;

                    foreach (int next in map[station]) {
                        if (!taken.Contains(next)) {
                            taking.Enqueue(next);
                            taken.Add(next);
                        }
                    }
                }
            }
            change++;
        }
        return -1;
    }
}
// @lc code=end

