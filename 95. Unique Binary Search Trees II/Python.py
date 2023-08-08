# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def generateTrees(self, n: int) -> List[Optional[TreeNode]]:
        self.dp = defaultdict(list)
        return self.helper(1, n)

    def helper(self, l, r):
        if (l, r) in self.dp:
            return self.dp[(l, r)]
        if l > r: return [None]

        for val in range(l, r+1):
            for left_subtree in self.helper(l, val-1):
                for right_subtree in self.helper(val+1, r):
                    root = TreeNode(val=val, left=left_subtree, right=right_subtree)
                    self.dp[(l, r)].append(root)
        return self.dp[(l, r)]
