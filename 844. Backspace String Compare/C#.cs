/*
 * @lc app=leetcode id=844 lang=csharp
 *
 * [844] Backspace String Compare
 */

// @lc code=start
public class Solution {
    public bool BackspaceCompare(string s, string t) {
        int si = s.Length -1, ti = t.Length - 1;
        int bs = 0, bt = 0;
        while (true) {
            Console.WriteLine($"{si} {ti}");
            while (si >= 0) {
                if (s[si] == '#') {
                    bs++;
                    si--;
                }
                else if (bs > 0) {
                    bs--;
                    si--;
                }
                else break;
            }
            while (ti >= 0) {
                if (t[ti] == '#') {
                    bt++;
                    ti--;
                }
                else if (bt > 0) {
                    bt--;
                    ti--;
                }
                else break;
            }
            if (si < 0 && ti < 0) return true;
            if (si < 0 || ti < 0) return false;
            if (s[si] != t[ti]) return false;
            si--;
            ti--;
        }
        return true;
    }
}
// @lc code=end

