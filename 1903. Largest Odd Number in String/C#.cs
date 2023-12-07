/*
 * @lc app=leetcode id=1903 lang=csharp
 *
 * [1903] Largest Odd Number in String
 */

// @lc code=start
public class Solution {
    public string LargestOddNumber(string num) {
        for (int i = num.Length - 1; i >= 0; i--) {
            if (((num[i] - '0') & 1) == 1) return num.Substring(0, i + 1);
        }
        return String.Empty;
    }
}
// @lc code=end

