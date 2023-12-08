/*
 * @lc app=leetcode id=606 lang=csharp
 *
 * [606] Construct String from Binary Tree
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public string Tree2str(TreeNode root) {
        StringBuilder s = new();
        if (root != null) {
            s.Append(root.val);
            if (root.right != null) {
                s.Append("(");
                s.Append(Tree2str(root.left));
                s.Append(")(");
                s.Append(Tree2str(root.right));
                s.Append(")");
            }
            else if (root.left != null) {
                s.Append("(");
                s.Append(Tree2str(root.left));
                s.Append(")");
            }
        }
        return s.ToString();
    }
}
// @lc code=end

