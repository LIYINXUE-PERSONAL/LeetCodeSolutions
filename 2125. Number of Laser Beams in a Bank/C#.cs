/*
 * @lc app=leetcode id=2125 lang=csharp
 *
 * [2125] Number of Laser Beams in a Bank
 */

// @lc code=start
public class Solution {
    public int NumberOfBeams(string[] bank) {
        int prev = 0, result = 0;
        foreach (string s in bank) {
            int cur = s.Count(x => x == '1');
            if (cur == 0) continue;
            result += prev * cur;
            prev = cur;
        }
        return result;
    }
}
// @lc code=end

