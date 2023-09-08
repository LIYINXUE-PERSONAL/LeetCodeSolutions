/*
 * @lc app=leetcode id=118 lang=csharp
 *
 * [118] Pascal's Triangle
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        var result = new List<IList<int>>
        {
            new List<int> { 1 }
        };

        for (int i = 1; i < numRows; i++) {
            result.Add(new List<int>(i + 1));
            result[^1].Add(1);
            for (int j = 1; j < i; j++) {
                result[^1].Add(result[^2][j - 1] + result[^2][j]);
            }
            result[^1].Add(1);
        }

        return result;
    }
}
// @lc code=end

