/*
 * @lc app=leetcode id=2264 lang=csharp
 *
 * [2264] Largest 3-Same-Digit Number in String
 */

// @lc code=start
public class Solution {
    public string LargestGoodInteger(string num) {
        ushort max = 0;

        for (int i = 2; i < num.Length; i++) {
            if (num[i] == num[i - 1] && num[i] == num[i - 2]) {
                max = Math.Max(max, num[i]);
            }
        }

        return max == 0 ? String.Empty : new String((char)max, 3);
    }
}
// @lc code=end

