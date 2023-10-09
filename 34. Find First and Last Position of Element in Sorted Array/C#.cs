/*
 * @lc app=leetcode id=34 lang=csharp
 *
 * [34] Find First and Last Position of Element in Sorted Array
 */

// @lc code=start
public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int left = BinarySearch.FindIndex(nums, target, BinarySearch.SearchOption.First);
        int right = BinarySearch.FindIndex(nums, target, BinarySearch.SearchOption.Last);
        return new int[] {left, right};
    }
}

public class BinarySearch {
    public enum SearchOption {
        First,
        Last
    }

    public static int FindIndex(int[] nums, int target, SearchOption option = SearchOption.First) {
        int index = -1;
        int left = 0, right = nums.Length - 1;
        while (left <= right) {
            int mid = left + (right - left) / 2;
            if (target == nums[mid]) {
                index = mid;
                switch (option) {
                case SearchOption.First:
                    right = mid - 1;
                    break;
                case SearchOption.Last:
                    left = mid + 1;
                    break;
                }
            }
            else if (target > nums[mid]) {
                left = mid + 1;
            }
            else {
                right = mid - 1;
            }
        }
        return index;
    }
}
// @lc code=end

