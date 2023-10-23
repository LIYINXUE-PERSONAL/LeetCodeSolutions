/*
 * @lc app=leetcode id=342 lang=csharp
 *
 * [342] Power of Four
 */

// @lc code=start
public class Solution {
    public bool IsPowerOfFour(int n) {
        if (n <= 0) return false;
        while (n > 1) {
            if ((n & 3) > 0) return false;
            n = n >> 2;
        }
        return true;
    }
}
// @lc code=end

