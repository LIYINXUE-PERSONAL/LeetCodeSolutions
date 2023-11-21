/*
 * @lc app=leetcode id=1814 lang=csharp
 *
 * [1814] Count Nice Pairs in an Array
 */

// @lc code=start
public class Solution {
    private int MOD = 1_000_000_007;

    public int CountNicePairs(int[] nums) {
        for (int i = 0; i < nums.Length; i++) {
            nums[i] -= Rev(nums[i]);
        }
        Dictionary<int, int> freq = new();
        int count = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (freq.ContainsKey(nums[i])) {
                count = (count + freq[nums[i]]) % MOD;
                freq[nums[i]]++;
            }
            else {
                freq[nums[i]] = 1;
            }
        }
        return count;
    }

    private int Rev(int num) {
        int rev = 0;
        while (num > 0) {
            rev *= 10;
            rev += num % 10;
            num /= 10;
        }
        return rev;
    }
}
// @lc code=end

