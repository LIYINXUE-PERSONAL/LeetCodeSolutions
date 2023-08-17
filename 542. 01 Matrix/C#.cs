public class Solution {
    public int[][] UpdateMatrix(int[][] mat) {
        int m = mat.Length, n = mat[0].Length;
        int max = m + n;
        int[][] dp = new int[m][];
        for (int i = 0; i < m; i++) {
            dp[i] = new int[n];
        }
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (mat[i][j] == 0) continue;
                int t = max, l = max;
                if (i > 0) t = dp[i - 1][j];
                if (j > 0) l = dp[i][j - 1];
                dp[i][j] = Math.Min(t, l) + 1;
            }
        }
        for (int i = m - 1; i >= 0; i--) {
            for (int j = n - 1; j >= 0; j--) {
                if (mat[i][j] == 0) continue;
                int b = max, r = max;
                if (i < m - 1) b = dp[i + 1][j];
                if (j < n - 1) r = dp[i][j + 1];
                dp[i][j] = Math.Min(dp[i][j], Math.Min(b, r) + 1);
            }
        }
        return dp;
    }
}