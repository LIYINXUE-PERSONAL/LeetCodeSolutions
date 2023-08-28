public class Solution {
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
}