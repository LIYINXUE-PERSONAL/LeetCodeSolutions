/*
 * @lc app=leetcode id=1220 lang=csharp
 *
 * [1220] Count Vowels Permutation
 */

// @lc code=start
public class Solution {
    private int[][] prev = new int[][] {
        new int[] {1, 2, 4}, //'ea','ia','ua'
        new int[] {0, 2}, //'ae','ie'
        new int[] {1, 3}, //'ei','oi'
        new int[] {2}, //'io'
        new int[] {2, 3} //'iu','ou'
    };

    private int MOD = 1_000_000_007;

    public int CountVowelPermutation(int n) {
        long[] dp = Enumerable.Repeat(1L, 5).ToArray();

        for (int i = 1; i < n; i++) {
            long[] next = new long[5];
            for (int j = 0; j < 5; j++) {
                foreach (int p in prev[j]) {
                    next[j] = (next[j] + dp[p]) % MOD;
                } 
            }
            dp = next;
        }

        return (int)(dp.Sum() % MOD);
    }
}
// @lc code=end

