/*
 * @lc app=leetcode id=229 lang=csharp
 *
 * [229] Majority Element II
 */

// @lc code=start
public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        int n1 = Int32.MaxValue, n2 = Int32.MaxValue, c1 = 0, c2 = 0;
        foreach (int num in nums) {
            if (c1 == 0 && n2 != num) {
                n1 = num;
                c1++;
            }
            else if (c2 == 0 && n1 != num) {
                n2 = num;
                c2++;
            }
            else if (n1 == num) {
                c1++;
            }
            else if (n2 == num) {
                c2++;
            }
            else {
                c1--;
                c2--;
            }
        }
        c1 = 0;
        c2 = 0;
        foreach (int num in nums) {
            if (num == n1) c1++;
            else if (num == n2) c2++;
        }
        List<int> result = new();
        int req = nums.Length / 3;
        if (c1 > req) result.Add(n1);
        if (c2 > req) result.Add(n2);
        return result;
    }
}
// @lc code=end

