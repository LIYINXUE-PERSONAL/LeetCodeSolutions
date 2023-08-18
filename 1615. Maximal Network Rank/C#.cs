public class Solution {
    public int MaximalNetworkRank(int n, int[][] roads) {
        int[] rank = new int[n];
        HashSet<int>[] sets = new HashSet<int>[n];
        for (int i = 0; i < n; i++) {
            sets[i] = new();
        }
        foreach (int[] road in roads) {
            rank[road[0]]++;
            rank[road[1]]++;
            sets[road[0]].Add(road[1]);
            sets[road[1]].Add(road[0]);
        }
        int max = 0;
        for (int i = 0; i < n; i++) {
            for (int j = i + 1; j < n; j++) {
                int deg = rank[i] + rank[j];
                if (sets[i].Contains(j)) deg--;
                max = Math.Max(max, deg);
            }
        }
        return max;
    }
}