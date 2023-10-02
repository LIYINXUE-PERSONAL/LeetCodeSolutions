/*
 * @lc app=leetcode id=2038 lang=csharp
 *
 * [2038] Remove Colored Pieces if Both Neighbors are the Same Color
 */

// @lc code=start
public class Solution {
    public bool WinnerOfGame(string colors) {
        int a = 0, b = 0;
        for (int i = 1; i < colors.Length - 1; i++) {
            if (colors[i] == colors[i - 1] && colors[i] == colors[i +1]) {
                if (colors[i] == 'A') a++;
                else b++;
            }
        }
        return a - b >= 1;
    }
}
// @lc code=end

