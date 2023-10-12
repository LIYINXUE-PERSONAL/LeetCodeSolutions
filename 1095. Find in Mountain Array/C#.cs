/*
 * @lc app=leetcode id=1095 lang=csharp
 *
 * [1095] Find in Mountain Array
 */

// @lc code=start
/**
 * // This is MountainArray's API interface.
 * // You should not implement it, or speculate about its implementation
 * class MountainArray {
 *     public int Get(int index) {}
 *     public int Length() {}
 * }
 */

class Solution {
    public int FindInMountainArray(int target, MountainArray mountainArr) {
        int n = mountainArr.Length();
        int peek = BinarySearch(0, n - 1, (int i) => mountainArr.Get(i) > mountainArr.Get(i + 1));
        int left = BinarySearch(0, peek, (int i) => mountainArr.Get(i) >= target);
        if (mountainArr.Get(left) == target) return left;
        int right = BinarySearch(peek, n - 1, (int i) => mountainArr.Get(i) <= target);
        if (mountainArr.Get(right) == target) return right;
        return -1;
    }

    public delegate bool Comparer(int index);

    private int BinarySearch(int left, int right, Comparer compare) {
        while (left < right) {
            int mid = left + (right - left) / 2;
            if (compare(mid)) right = mid;
            else left = mid + 1;
        }
        return left;
    }
}
// @lc code=end

