/*
 * @lc app=leetcode id=138 lang=csharp
 *
 * [138] Copy List with Random Pointer
 */

// @lc code=start
/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    Dictionary<Node, Node> map;

    public Node CopyRandomList(Node head) {
        map = new();
        return Clone(head);
    }

    private Node Clone(Node node) {
        if (node == null) return null;
        if (map.ContainsKey(node)) return map[node];
        map[node] = new Node(node.val);
        map[node].next = Clone(node.next);
        map[node].random = Clone(node.random);
        return map[node];
    }
}
// @lc code=end

