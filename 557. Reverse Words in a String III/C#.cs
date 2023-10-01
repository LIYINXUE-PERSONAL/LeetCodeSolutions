/*
 * @lc app=leetcode id=557 lang=csharp
 *
 * [557] Reverse Words in a String III
 */

// @lc code=start
public class Solution {
    public string ReverseWords(string s) {
        string result = String.Empty;
        Stack<char> stack = new();
        foreach (char c in s) {
            if (c == ' ') {
                result += new string(stack.ToArray());
                result += ' ';
                stack.Clear();
            }
            else {
                stack.Push(c);
            }
        }
        result += new string(stack.ToArray());
        return result;
    }
}
// @lc code=end

