/*
 * @lc app=leetcode id=458 lang=csharp
 *
 * [458] Poor Pigs
 */

// @lc code=start
public class Solution {
    public int PoorPigs(int buckets, int minutesToDie, int minutesToTest) {
        int states = minutesToTest/minutesToDie + 1;
        int pigs = 0;
        while (Math.Pow(states, pigs) < buckets) {
            pigs++;
        }
        return pigs;
    }
}
// @lc code=end

