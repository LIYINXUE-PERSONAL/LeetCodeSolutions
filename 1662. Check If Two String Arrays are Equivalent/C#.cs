/*
 * @lc app=leetcode id=1662 lang=csharp
 *
 * [1662] Check If Two String Arrays are Equivalent
 */

// @lc code=start
public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        return String.Concat(word1) == String.Concat(word2);
    }
}
// @lc code=end

