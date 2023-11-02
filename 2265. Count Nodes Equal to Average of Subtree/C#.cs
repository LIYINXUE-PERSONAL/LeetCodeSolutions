/*
 * @lc app=leetcode id=2265 lang=csharp
 *
 * [2265] Count Nodes Equal to Average of Subtree
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
    private int result;

    public int AverageOfSubtree(TreeNode root) {
        result = 0;
        FindCountAndSum(root);
        return result;
    }

    private (int count, int sum) FindCountAndSum(TreeNode node) {
        if (node == null) return (0, 0);
        (int count, int sum) left = FindCountAndSum(node.left);
        (int count, int sum) right = FindCountAndSum(node.right);
        int count = left.count + right.count + 1;
        int sum = left.sum + right.sum + node.val;
        if (sum / count == node.val) result++;
        return (count, sum);
    }
}
// @lc code=end

