/*
 * @lc app=leetcode id=823 lang=csharp
 *
 * [823] Binary Trees With Factors
 */

// @lc code=start
public class Solution {
    private int MOD = 1_000_000_007;

    public int NumFactoredBinaryTrees(int[] arr) {
        Array.Sort(arr);
        Dictionary<int, long> dp = new();
        foreach (int i in arr) {
            long count = 1;
            foreach (int key in dp.Keys) {
                if (i % key == 0) {
                    int j = i / key;
                    if (dp.ContainsKey(j)) count += dp[j] * dp[key];
                }
            }
            dp[i] = count % MOD;
        }
        return (int)(dp.Values.Sum() % MOD);
    }
}
// @lc code=end

