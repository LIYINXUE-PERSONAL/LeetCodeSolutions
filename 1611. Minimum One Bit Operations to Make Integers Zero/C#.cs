/*
 * @lc app=leetcode id=1611 lang=csharp
 *
 * [1611] Minimum One Bit Operations to Make Integers Zero
 */

// @lc code=start
public class Solution {
    public int MinimumOneBitOperations(int n) {
        int ans = n;
        ans ^= ans >> 16;
        ans ^= ans >> 8;
        ans ^= ans >> 4;
        ans ^= ans >> 2;
        ans ^= ans >> 1;
        return ans;
    }
}
// @lc code=end

