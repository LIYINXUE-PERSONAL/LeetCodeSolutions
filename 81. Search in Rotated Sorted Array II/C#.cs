public class Solution {
    public bool Search(int[] nums, int target) {
        return BinarySearch(nums, target);
    }

    /// <summary>
    /// Search using binarysearch, best case: O(log N)
    /// Due to deduplicate process, worst case: O(N)
    /// </summary>
    private bool BinarySearch(int[] nums, int target) {
        int left = 0, right = nums.Length - 1;
        while (left <= right) {
            while (left < right && nums[left] == nums[left + 1]) left++;
            while (left < right && nums[right] == nums[right - 1]) right--;
            int mid = (left + right) / 2;
            if (nums[left] == target || nums[mid] == target || nums[right] == target) return true;
            if (nums[mid] >= nums[left]) {
                if (nums[mid] > target && nums[left] <= target) {
                    right = mid - 1;
                }
                else {
                    left = mid + 1;
                }
            }
            else {
                if (nums[mid] < target && nums[right] >= target) {
                    left = mid + 1;
                }
                else {
                    right = mid - 1;
                }
            }
        }
        return false;
    }

    /// <summary>
    /// Search in linear time: O(N), faster in LeetCode though
    /// </summary>
    private bool LinearSearch(int[] nums, int target) {
        foreach (int i in nums) {
            if (i == target) return true;
        }
        return false;
    }

    private bool HashSetSearch(int[] nums, int target) {
        HashSet<int> set = new HashSet<int>(nums);
        return set.Contains(target);
    }
}