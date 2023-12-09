/*
 * @lc app=leetcode id=94 lang=csharp
 *
 * [94] Binary Tree Inorder Traversal
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
    List<int> inorder;

    public IList<int> InorderTraversal(TreeNode root) {
        inorder = new();
        Inorder(root);
        return inorder;
    }

    private void Inorder(TreeNode node) {
        if (node == null) return;
        Inorder(node.left);
        inorder.Add(node.val);
        Inorder(node.right);
    }
}
// @lc code=end

