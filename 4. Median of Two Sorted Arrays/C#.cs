/*
 * @lc app=leetcode id=4 lang=csharp
 *
 * [4] Median of Two Sorted Arrays
 */

// @lc code=start
public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        if (nums1.Length > nums2.Length) return FindMedianSortedArrays(nums2, nums1);
        
        int xl = nums1.Length, yl = nums2.Length, mid = (xl + yl + 1) / 2;
        int left = 0, right = xl;
        
        while (left <= right) {
            int pX = (left + right) / 2;
            int pY = mid - pX;
            
            int x1 = pX == 0 ? Int32.MinValue : nums1[pX - 1];
            int x2 = pX == xl ? Int32.MaxValue : nums1[pX];
            int y1 = pY == 0 ? Int32.MinValue : nums2[pY - 1];
            int y2 = pY == yl ? Int32.MaxValue : nums2[pY];
            
            bool c1 = x1 <= y2, c2 = y1 <= x2;
            if (c1 && c2) {
                if ((xl + yl) % 2 == 0) return Average(Math.Max(x1, y1), Math.Min(x2, y2));
                return Math.Max(x1, y1);
            }
            if (!c1) right = pX - 1;
            else left = pX + 1;
        }
        
        return 0;
    }
    
    private double Average(int a, int b) {
        return (double)(a + b) / 2.0;
    }
}
// @lc code=end

