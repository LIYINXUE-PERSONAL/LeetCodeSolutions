/*
 * @lc app=leetcode id=2642 lang=csharp
 *
 * [2642] Design Graph With Shortest Path Calculator
 */

// @lc code=start
public class Graph {
    private int[,] map;
    private int MAX = 1_000_000_007;
    private int n;

    public Graph(int n, int[][] edges) {
        this.n = n;
        map = new int[n,n];
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                if (i != j) map[i,j] = MAX;
            }
        }
        foreach (int[] edge in edges) {
            AddEdge(edge);
        }
    }
    
    public void AddEdge(int[] edge) {
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                int cost = map[i,edge[0]] + map[edge[1],j] + edge[2];
                map[i,j] = Math.Min(map[i,j], cost);
            }
        }
    }
    
    public int ShortestPath(int node1, int node2) {
        if (map[node1, node2] == MAX) return -1;
        return map[node1, node2];
    }
}

/**
 * Your Graph object will be instantiated and called as such:
 * Graph obj = new Graph(n, edges);
 * obj.AddEdge(edge);
 * int param_2 = obj.ShortestPath(node1,node2);
 */
// @lc code=end

