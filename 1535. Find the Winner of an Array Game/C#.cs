/*
 * @lc app=leetcode id=1535 lang=csharp
 *
 * [1535] Find the Winner of an Array Game
 */

// @lc code=start
public class Solution {
    public int GetWinner(int[] arr, int k) {
        int max = arr.Max(), cur = arr[0], count = 0;
        for (int i = 1; i < arr.Length; i++) {
            if (cur > arr[i]) count++;
            else {
                cur = arr[i];
                count = 1;
            }
            if (count == k) return cur;
        }
        return max;
    }
}
// @lc code=end

