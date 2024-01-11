/*
 * @lc app=leetcode id=1026 lang=csharp
 *
 * [1026] Maximum Difference Between Node and Ancestor
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
    public int MaxAncestorDiff(TreeNode root) {
        return MaxDiff(root, root.val, root.val);
    }

    private int MaxDiff(TreeNode node, int max, int min) {
        if (node == null) return 0;
        int maxDiff = Math.Max(AbsDiff(node.val, max), AbsDiff(node.val, min));
        max = Math.Max(max, node.val);
        min = Math.Min(min, node.val);
        int childMaxDiff = Math.Max(MaxDiff(node.left, max, min),MaxDiff(node.right, max, min));
        return Math.Max(maxDiff, childMaxDiff);
    }

    private int AbsDiff(int a, int b) => Math.Abs(a - b);
}
// @lc code=end

