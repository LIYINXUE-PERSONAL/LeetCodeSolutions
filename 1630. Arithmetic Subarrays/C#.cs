/*
 * @lc app=leetcode id=1630 lang=csharp
 *
 * [1630] Arithmetic Subarrays
 */

// @lc code=start
public class Solution {
    private int[] nums;

    public IList<bool> CheckArithmeticSubarrays(int[] nums, int[] l, int[] r) {
        this.nums = nums;
        bool[] result = new bool[l.Length];
        for (int i = 0; i < l.Length; i++) {
            result[i] = CheckArithmeticSubarray(l[i], r[i]);
        }
        return result;
    }
    
    private bool CheckArithmeticSubarray(int l, int r) {
        if (r - l <= 1) return true;
        int min = Int32.MaxValue, max = Int32.MinValue;
        HashSet<int> set = new(r - l + 1);
        for (int i = l; i <= r; i++) {
            min = Math.Min(min, nums[i]);
            max = Math.Max(max, nums[i]);
            set.Add(nums[i]);
        }
        if ((max - min) % (r - l) != 0) return false;
        int diff = (max - min) / (r - l);
        if (diff == 0) return set.Count == 1;
        int cur = min;
        while (cur <= max) {
            if (!set.Contains(cur)) return false;
            cur += diff;
        }
        return true;
    }
}
// @lc code=end

