/*
 * @lc app=leetcode id=2433 lang=csharp
 *
 * [2433] Find The Original Array of Prefix Xor
 */

// @lc code=start
public class Solution {
    public int[] FindArray(int[] pref) {
        int n = pref.Length;
        int[] result = new int[n];
        result[0] = pref[0];
        for (int i = 1; i < n; i++) {
            result[i] = pref[i] ^ pref[i - 1];
        }
        return result;
    }
}
// @lc code=end

