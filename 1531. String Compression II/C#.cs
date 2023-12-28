/*
 * @lc app=leetcode id=1531 lang=csharp
 *
 * [1531] String Compression II
 */

// @lc code=start
public class Solution {
    private int?[,,,] memo;
    private string s;
    
    public int GetLengthOfOptimalCompression(string s, int k) {
        this.s = s;
        this.memo = new int?[s.Length + 1, 27, s.Length + 1, k + 1];
        return Calc(0, 26, 0, k);
    }
    
    private int Calc(int i, int lastChar, int lastCount, int k) {
        if (k < 0) return 101;
        if (i + k >= s.Length) return 0;

        if (memo[i, lastChar, lastCount, k] != null) return memo[i, lastChar, lastCount, k].Value;
        int result = 0;

        if (s[i] - 'a' == lastChar) {
            result = (lastCount == 1 || lastCount == 9 || lastCount == 99 ? 1 : 0) + Calc(i + 1, lastChar, lastCount + 1, k);
        }
        else {
            result = Math.Min(1 + Calc(i + 1, s[i] - 'a', 1, k), Calc(i + 1, lastChar, lastCount, k - 1));
        }
        
        memo[i, lastChar, lastCount, k] = result;
        return result;
    }
}
// @lc code=end

