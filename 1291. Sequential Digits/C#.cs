/*
 * @lc app=leetcode id=1291 lang=csharp
 *
 * [1291] Sequential Digits
 */

// @lc code=start
public class Solution {
    public IList<int> SequentialDigits(int low, int high) {
        List<int> result = new();
        for (int i = 1; i < 9; i++) {
            int cur = i;
            int next = i + 1;
            while (cur <= high && next <= 9) {
                cur = cur * 10 + next++;
                if (cur >= low && cur <= high) result.Add(cur);
            }
        }
        result.Sort();
        return result;
    }
}
// @lc code=end

