/*
 * @lc app=leetcode id=1457 lang=csharp
 *
 * [1457] Pseudo-Palindromic Paths in a Binary Tree
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
    private int count = 0;
    
    public int PseudoPalindromicPaths (TreeNode root) {
        Helper(root, new());
        return count;
    }

    private void Helper(TreeNode node, HashSet<int> set) {
        if (node == null) return;
        if (set.Contains(node.val)) set.Remove(node.val);
        else set.Add(node.val);
        if (node.left == null && node.right == null && set.Count <= 1) count++;
        Helper(node.left, set);
        Helper(node.right, set);
        if (set.Contains(node.val)) set.Remove(node.val);
        else set.Add(node.val);
    }
 }
// @lc code=end

