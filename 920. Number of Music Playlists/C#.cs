public class Solution {
    private int MOD = 1_000_000_007;

    public int NumMusicPlaylists(int n, int goal, int k) {
        int[,] dp = new int[goal + 1, n + 1];
        dp[0,0] = 1;
        for (int i = 1; i <= goal; i++) {
            for (int j = 1; j <= Math.Min(i, n); j++) {
                long cur = (long)dp[i - 1, j - 1] * (n - j + 1);
                if (j > k) {
                    cur += (long)dp[i - 1, j] * (j - k);
                }
                dp[i, j] = (int)(cur % MOD);
            }
        }
        return dp[goal, n];
    }
}