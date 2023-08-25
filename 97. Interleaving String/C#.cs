public class Solution {
    public bool IsInterleave(string s1, string s2, string s3) {
        if (s3.Length != s1.Length + s2.Length) return false;
        bool[,] dp = new bool[s1.Length + 1, s2.Length + 1];
        dp[0,0] = true;
        for (int i = 0; i < s1.Length; i++) {
            dp[i + 1, 0] = s3[i] == s1[i] && dp[i, 0];
        }
        for (int j = 0; j < s2.Length; j++) {
            dp[0, j + 1] = s3[j] == s2[j] && dp[0, j];
        }
        for (int i = 0; i < s1.Length; i++) {
            for (int j = 0; j < s2.Length; j++) {
                bool c1 = s3[i + j + 1] == s1[i] && dp[i, j + 1], c2 = s3[i + j + 1] == s2[j] && dp[i + 1, j];
                dp[i + 1, j + 1] = c1 || c2;
            }
        }
        return dp[s1.Length, s2.Length];
    }
}