/*
 * @lc app=leetcode id=1359 lang=csharp
 *
 * [1359] Count All Valid Pickup and Delivery Options
 */

// @lc code=start
public class Solution {
    private int MOD = 1_000_000_007;

    public int CountOrders(int n) {
        return (int)(Factorial(2 * n) / BigInteger.Pow(2, n) % MOD);
    }

    private BigInteger Factorial(int n) {
        BigInteger result = 1;
        for (int i = 1; i <= n; i++) {
            result *= i;
        }
        return result;
    }
}
// @lc code=end

