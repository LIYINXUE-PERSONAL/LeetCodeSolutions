/*
 * @lc app=leetcode id=1846 lang=csharp
 *
 * [1846] Maximum Element After Decreasing and Rearranging
 */

// @lc code=start
public class Solution {
    public int MaximumElementAfterDecrementingAndRearranging(int[] arr) {
        Array.Sort(arr);
        int result = 1;
        for (int i = 1; i < arr.Length; i++) {
            if (arr[i] > result) result++;
        }
        return result;
    }
}
// @lc code=end

