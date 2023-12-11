/*
 * @lc app=leetcode id=1287 lang=csharp
 *
 * [1287] Element Appearing More Than 25% In Sorted Array
 */

// @lc code=start
public class Solution {
    public int FindSpecialInteger(int[] arr) {
        if (arr.Length == 1) return arr[0];
        int count = 1;
        double expected = ((double)arr.Length) / 4.0;
        for (int i = 1; i < arr.Length; i++) {
            if (arr[i] == arr[i - 1]) {
                count++;
                if (count > expected) return arr[i];
            }
            else {
                count = 1;
            }
        }
        return -1;
    }
}
// @lc code=end

