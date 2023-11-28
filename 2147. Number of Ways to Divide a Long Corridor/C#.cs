/*
 * @lc app=leetcode id=2147 lang=csharp
 *
 * [2147] Number of Ways to Divide a Long Corridor
 */

// @lc code=start
public class Solution {
    private int MOD = 1_000_000_007;

    public int NumberOfWays(string corridor) {
        long ways = 1;
        bool seatFound = false;
        int prev = -1;
        for (int i = 0; i < corridor.Length; i++) {
            if (corridor[i] == 'S') {
                seatFound = !seatFound;
                if (!seatFound) {
                    prev = i;
                }
                else if (prev >= 0) {
                    ways *= (i - prev);
                    ways %= MOD; 
                }
            }
        }
        if (seatFound || prev == -1) return 0;
        return (int)(ways % MOD);
    }
}
// @lc code=end

