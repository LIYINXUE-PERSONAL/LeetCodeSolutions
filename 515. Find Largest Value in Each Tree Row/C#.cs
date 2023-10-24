/*
 * @lc app=leetcode id=515 lang=csharp
 *
 * [515] Find Largest Value in Each Tree Row
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
    public IList<int> LargestValues(TreeNode root) {
        Queue<TreeNode> queue = new();
        List<int> result = new();
        if (root != null) queue.Enqueue(root);
        while (queue.Count > 0) {
            int count = queue.Count;
            int max = Int32.MinValue;
            while (count --> 0) {
                TreeNode node = queue.Dequeue();
                max = Math.Max(max, node.val);
                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }
            result.Add(max);
        }
        return result;
    }
}
// @lc code=end

