public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0, right = nums.Length - 1;
        while (left <= right) {
            int mid = (left + right) / 2;
            // if (nums[left] == target) return left;
            if (nums[mid] == target) return mid;
            // if (nums[right] == target) return right;
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
        return -1;
    }
}