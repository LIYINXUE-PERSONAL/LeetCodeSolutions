/*
 * @lc app=leetcode id=1716 lang=csharp
 *
 * [1716] Calculate Money in Leetcode Bank
 */

// @lc code=start
public class Solution {
    public int TotalMoney(int n) {
        int week = n / 7;
        int day = n % 7;
        return week * 28 + week * (week - 1) * 7 / 2 + day * (week + 1) + day * (day - 1) / 2;
    }
}
// @lc code=end

