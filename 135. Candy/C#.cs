/*
 * @lc app=leetcode id=135 lang=csharp
 *
 * [135] Candy
 */

// @lc code=start
public class Solution {
    public int Candy(int[] ratings) {
        int[] k = new int[ratings.Length];
        
        for (int i = 1; i < ratings.Length; i++) {
            if (ratings[i] > ratings[i - 1]) k[i] = k[i - 1] + 1;
        }

        for (int i = ratings.Length - 2; i >= 0; i--) {
            if (ratings[i] > ratings[i + 1]) k[i] = Math.Max(k[i], k[i + 1] + 1);
        }

        return k.Sum() + ratings.Length;
    }
}
// @lc code=end

