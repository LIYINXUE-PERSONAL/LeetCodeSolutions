/*
 * @lc app=leetcode id=150 lang=csharp
 *
 * [150] Evaluate Reverse Polish Notation
 */

// @lc code=start
public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new();
        foreach (string token in tokens) {
            if (Int32.TryParse(token, out int result)) {
                stack.Push(result);
            }
            else {
                int i2 = stack.Pop(), i1 = stack.Pop();
                switch (token) {
                case "+":
                    stack.Push(i1 + i2);
                    break;
                case "-":
                    stack.Push(i1 - i2);
                    break;
                case "*":
                    stack.Push(i1 * i2);
                    break;
                case "/":
                    stack.Push(i1 / i2);
                    break;
                default:
                    continue;
                }
            }
        }
        return stack.Peek();
    }
}
// @lc code=end

