/*
 * @lc app=leetcode id=905 lang=csharp
 *
 * [905] Sort Array By Parity
 */

// @lc code=start
public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        List<int> a = new(), b = new();
        foreach (int n in nums) {
            if (n % 2 == 0) a.Add(n);
            else b.Add(n);
        }
        a.AddRange(b);
        return a.ToArray();
    }

    public int[] SortArrayByParityUsingArraySort(int[] nums) {
        Array.Sort(nums, (a, b) => (a%2).CompareTo(b%2));
        return nums;
    }
}
// @lc code=end

