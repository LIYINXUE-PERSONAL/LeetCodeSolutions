/*
 * @lc app=leetcode id=119 lang=csharp
 *
 * [119] Pascal's Triangle II
 */

// @lc code=start
public class Solution {
    public IList<int> GetRow(int rowIndex) {
        var result = Enumerable.Repeat<int>(1, rowIndex + 1).ToList();
        
        for (int row = 1; row < rowIndex; row++) {
            for (int col = row; col >= 1; col--) {
                result[col] = result[col-1] + result[col];
            }
        }
        
        return result;
    }
}
// @lc code=end

