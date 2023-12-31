/*
 * @lc app=leetcode id=1624 lang=csharp
 *
 * [1624] Largest Substring Between Two Equal Characters
 */

// @lc code=start
public class Solution {
    public int MaxLengthBetweenEqualCharacters(string s) {
        int?[] earlest = new int?[26];
        int result = -1;
        for (int i = 0; i < s.Length; i++) {
            int c = s[i] - 'a';
            if (earlest[c] == null) earlest[c] = i;
            else result = Math.Max(result, i - earlest[c].Value - 1);
        }
        return result;
    }
}
// @lc code=end

