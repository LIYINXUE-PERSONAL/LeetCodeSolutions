/*
 * @lc app=leetcode id=1356 lang=csharp
 *
 * [1356] Sort Integers by The Number of 1 Bits
 */

// @lc code=start
using static System.Runtime.Intrinsics.X86.Popcnt;

public class Solution {
    public int[] SortByBits(int[] arr) {
        Array.Sort(arr, PopCountComparer);
        return arr;
    }

    private static int PopCountComparer(int a, int b) {
        uint _a = PopCount((uint)a), _b = PopCount((uint)b);
        if (_a == _b) return a.CompareTo(b);
        return _a.CompareTo(_b);
    }
}
// @lc code=end

