/*
 * @lc app=leetcode id=2706 lang=csharp
 *
 * [2706] Buy Two Chocolates
 */

// @lc code=start
public class Solution {
    public int BuyChoco(int[] prices, int money) {
        int min = Int32.MaxValue, min2 = Int32.MaxValue;
        foreach (int price in prices) {
            if (price < min) {
                min2 = min;
                min = price;
            }
            else if (price < min2) {
                min2 = price;
            }
        }
        return money - (min + min2 <= money ? min + min2 : 0);
    }
}
// @lc code=end

