public class Solution {
    // DP
    public bool CanCross(int[] stones) {
        int n = stones.Length;
        if (stones[1] != 1) return false;
        Dictionary<int, int> map = new();
        for (int i = 0; i < n; i++) {
            map[stones[i]] = i;
        }
        bool[,] dp = new bool[n, n];
        dp[1, 0] = true;
        for (int i = 1; i < n - 1; i++) {
            for (int j = 0; j < i; j++) {
                if (dp[i, j]) {
                    int k = stones[i] - stones[j];
                    int next = stones[i] + k;
                    if (map.ContainsKey(next)) dp[map[next], i] = true;
                    if (map.ContainsKey(next + 1)) dp[map[next + 1], i] = true;
                    if (map.ContainsKey(next - 1)) dp[map[next - 1], i] = true;
                }
            }
        }
        for (int i = 0; i < n; i++) {
            if (dp[n - 1, i]) return true;
        }
        return false;
    }

    // PriorityQueue
    public bool CanCross(int[] stones) {
        int n = stones.Length;
        Dictionary<int, int> map = new();
        for (int i = 0; i < n; i++) {
            map[stones[i]] = i;
        }
        PriorityQueue<(int i, int k), int> pq = new();
        HashSet<(int i, int k)> visited = new();
        pq.Enqueue((0, 0), 0);
        while (pq.Count > 0) {
            (int i, int k) cur = pq.Dequeue();
            if (cur.i == n - 1) return true;
            for (int j = -1; j <= 1; j++) {
                int next = stones[cur.i] + cur.k + j;
                if (next <= stones[cur.i]) continue;
                if (map.ContainsKey(next)) {
                    (int i, int k) _next = (map[next], next - stones[cur.i]);
                    if (!visited.Contains(_next)) {
                        pq.Enqueue(_next, -map[next]);
                        visited.Add(_next);
                    }
                }
            }
        }
        return false;
    }
}