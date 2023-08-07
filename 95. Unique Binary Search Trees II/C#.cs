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
    private List<TreeNode>[,] memo;

    public IList<TreeNode> GenerateTrees(int n) {
        memo = new List<TreeNode>[n + 1, n + 1];
        return GetAllBST(1, n);
    }

    private List<TreeNode> GetAllBST(int start, int end) {
        List<TreeNode> result = new();
        if (start > end) {
            result.Add(null);
            return result;
        }
        if (memo[start, end] != null) return memo[start, end];
        for (int i = start; i <= end; i++) {
            List<TreeNode> left = GetAllBST(start, i - 1);
            List<TreeNode> right = GetAllBST(i + 1, end);

            foreach (TreeNode l in left) {
                foreach (TreeNode r in right) {
                    TreeNode root = new(i, l, r);
                    result.Add(root);
                }
            }
        }
        return memo[start, end] = result;
    }
}