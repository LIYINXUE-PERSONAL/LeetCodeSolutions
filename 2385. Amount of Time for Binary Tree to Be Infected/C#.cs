/*
 * @lc app=leetcode id=2385 lang=csharp
 *
 * [2385] Amount of Time for Binary Tree to Be Infected
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
    public class UndirectedMap {
        private Dictionary<int, List<int>> map = new();

        public void ImportFrom(TreeNode node) {
            AddNode(node.val);
            if (node.left != null) {
                AddNode(node.left.val);
                AddRelations(node.val, node.left.val);
                ImportFrom(node.left);
            }
            if (node.right != null) {
                AddNode(node.right.val);
                AddRelations(node.val, node.right.val);
                ImportFrom(node.right);
            }
        }

        private void AddNode(int node) {
            if (!map.ContainsKey(node)) map[node] = new();
        }

        private void AddRelations(int node1, int node2) {
            map[node1].Add(node2);
            map[node2].Add(node1);
        }

        public int GetAllLevelsFrom(int start) {
            HashSet<int> visited = new();
            Queue<int> queue = new();
            if (map.ContainsKey(start)) {
                queue.Enqueue(start);
                visited.Add(start);
            }
            int level = 0;
            while (queue.Count > 0) {
                int cur = queue.Count;
                while (cur --> 0) {
                    int node = queue.Dequeue();
                    foreach (int next in map[node]) {
                        if (!visited.Contains(next)) {
                            queue.Enqueue(next);
                            visited.Add(next);
                        }
                    }
                }
                level++;
            }
            return level;
        }
    }

    private UndirectedMap map = new();

    public int AmountOfTime(TreeNode root, int start) {
        if (root == null) return -1;
        map.ImportFrom(root);
        return map.GetAllLevelsFrom(start) - 1;
    }
}
// @lc code=end

