/*
 * @lc app=leetcode id=1464 lang=csharp
 *
 * [1464] Maximum Product of Two Elements in an Array
 */

// @lc code=startpublic class Solution {
public class Solution {
    public int MaxProduct(int[] nums) {
        int largest = 1, secondLargest = 1;
        foreach (int n in nums) {
            if (n > largest) {
                secondLargest = largest;
                largest = n;
            }
            else if (n > secondLargest) {
                secondLargest = n;
            }
        }
        return (largest - 1) * (secondLargest - 1);
    }
}
// @lc code=end

