/*
 * @lc app=leetcode id=501 lang=csharp
 *
 * [501] Find Mode in Binary Search Tree
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
    List<int> result;
    int maxCount, curCount, curNum;

    public int[] FindMode(TreeNode root) {
        result = new();
        maxCount = 0;
        curCount = 0;
        curNum = Int32.MinValue;

        GetNode(root);

        return result.ToArray();
    }

    private void GetNode(TreeNode node) {
        if (node == null) return;
        GetNode(node.left);
        if (node.val == curNum) curCount++;
        else {
            curNum = node.val;
            curCount = 1;
        }
        if (curCount > maxCount) {
            maxCount = curCount;
            result = new();
            result.Add(curNum);
        }
        else if (curCount == maxCount) {
            result.Add(curNum);
        }
        GetNode(node.right);
    }
}
// @lc code=end

