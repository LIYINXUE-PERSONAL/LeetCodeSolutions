/*
 * @lc app=leetcode id=343 lang=csharp
 *
 * [343] Integer Break
 */

// @lc code=start
public class Solution {
    public int IntegerBreak(int n) {
        if (n == 2) return 1;
        if (n == 3) return 2;
        int threes = n / 3;
        int rem = n % 3;
        switch (rem) {
            case 0:
                return (int)Math.Pow(3, threes);
            case 1:
                return (int)Math.Pow(3, threes - 1) * 4;
            case 2:
                return (int)Math.Pow(3, threes) * 2;
            default:
                return 0;
        }
    }
}
// @lc code=end

