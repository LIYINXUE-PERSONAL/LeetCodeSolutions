public class Solution {
    public int FindLongestChain(int[][] pairs) {
        Array.Sort(pairs, (int[] a, int[] b) => a[0].CompareTo(b[0]));
        int[] dp = Enumerable.Repeat(1, pairs.Length).ToArray();
        int max = dp[0];
        for (int i = 1; i < pairs.Length; i++) {
            for (int j = 0; j < i; j++) {
                if (pairs[i][0] > pairs[j][1]) dp[i] = Math.Max(dp[i], dp[j] + 1);
            }
            max = Math.Max(max, dp[i]);
        }
        return max;
    }
}