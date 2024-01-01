/*
 * @lc app=leetcode id=455 lang=csharp
 *
 * [455] Assign Cookies
 */

// @lc code=start
public class Solution {
    public int FindContentChildren(int[] g, int[] s) {
        Array.Sort(g);
        Array.Sort(s);
        int gi = 0, si = 0;
        while (gi < g.Length && si < s.Length) {
            if (s[si] >= g[gi]) gi++;
            si++;
        }
        return gi;
    }
}
// @lc code=end

