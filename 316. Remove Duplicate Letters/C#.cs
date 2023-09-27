/*
 * @lc app=leetcode id=316 lang=csharp
 *
 * [316] Remove Duplicate Letters
 */

// @lc code=start
public class Solution {
    public string RemoveDuplicateLetters(string s) {
        Stack<char> stack = new();
        HashSet<char> seen = new();
        Dictionary<char, int> last = new(26);
        for (int i = 0; i < s.Length; i++) {
            last[s[i]] = i;
        }
        for (int i = 0; i < s.Length; i++) {
            if (!seen.Contains(s[i])) {
                while (stack.Count > 0 && s[i] < stack.Peek() && i < last[stack.Peek()]) {
                    seen.Remove(stack.Pop());
                }
                seen.Add(s[i]);
                stack.Push(s[i]);
            }
        }
        char[] result = stack.ToArray();
        Array.Reverse(result);
        return new string(result);
    }
}
// @lc code=end

