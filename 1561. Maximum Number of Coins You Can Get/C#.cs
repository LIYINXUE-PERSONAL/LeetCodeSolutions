/*
 * @lc app=leetcode id=1561 lang=csharp
 *
 * [1561] Maximum Number of Coins You Can Get
 */

// @lc code=start
public class Solution {
    public int MaxCoins(int[] piles) {
        Array.Sort(piles);
        int total = 0;
        for (int i = piles.Length - 2; i >= piles.Length / 3; i -= 2) {
            total += piles[i];
        }
        return total;
    }
}
// @lc code=end

