/*
 * @lc app=leetcode id=935 lang=csharp
 *
 * [935] Knight Dialer
 */

// @lc code=start
public class Solution {
    private int[][] map = new int[][] {
        new int[] {4, 6},
        new int[] {6, 8},
        new int[] {7, 9},
        new int[] {4, 8},
        new int[] {3, 9, 0},
        new int[] {},
        new int[] {1, 7, 0},
        new int[] {2, 6},
        new int[] {1, 3},
        new int[] {4, 2}
    };
    private int[,] cache;
    private int MOD = 1_000_000_007;

    public int KnightDialer(int n) {
        this.cache = new int[10, n + 1];
        int total = 0;
        for (int i = 0; i < 10; i++) {
            total = (total + Calculate(i, n - 1)) % MOD;
        }
        return total;
    }

    private int Calculate(int cur, int rem) {
        if (cache[cur, rem] > 0) return cache[cur, rem];
        if (rem == 0) return cache[cur, rem] = 1;
        int sum = 0;
        foreach (int next in map[cur]) {
            sum = (sum + Calculate(next, rem - 1)) % MOD;
        }
        return cache[cur, rem] = sum;
    }
}
// @lc code=end

