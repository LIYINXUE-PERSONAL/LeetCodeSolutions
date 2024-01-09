/*
 * @lc app=leetcode id=872 lang=csharp
 *
 * [872] Leaf-Similar Trees
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
    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        List<int> l1 = new(), l2 = new();
        AddLeavesToList(root1, l1);
        AddLeavesToList(root2, l2);
        return l1.SequenceEqual(l2);
    }

    private void AddLeavesToList(TreeNode node, List<int> list) {
        if (node == null) return;
        if (node.left == null && node.right == null) list.Add(node.val);
        else {
            AddLeavesToList(node.left, list);
            AddLeavesToList(node.right, list);
        }
    }
}
// @lc code=end

