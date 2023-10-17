/*
 * @lc app=leetcode id=1361 lang=csharp
 *
 * [1361] Validate Binary Tree Nodes
 */

// @lc code=start
public class Solution {
    private int n;
    private int[] leftChild, rightChild;
    HashSet<int> seen;

    public bool ValidateBinaryTreeNodes(int n, int[] leftChild, int[] rightChild) {
        this.n = n;
        this.leftChild = leftChild;
        this.rightChild = rightChild;

        int root = FindRoot();
        if (root == -1) return false;

        this.seen = new();
        return BuildBST(root) && this.seen.Count == n;
    }

    private int FindRoot() {
        HashSet<int> elements = new(Enumerable.Range(0, n));
        foreach (int e in leftChild) {
            elements.Remove(e);
        }
        foreach (int e in rightChild) {
            elements.Remove(e);
        }
        return elements.Count == 1 ? elements.ToArray()[0] : -1;
    }

    private bool BuildBST(int root) {
        if (root == -1) return true;
        if (this.seen.Contains(root)) return false;
        this.seen.Add(root);
        return BuildBST(leftChild[root]) && BuildBST(rightChild[root]);
    }
}
// @lc code=end

