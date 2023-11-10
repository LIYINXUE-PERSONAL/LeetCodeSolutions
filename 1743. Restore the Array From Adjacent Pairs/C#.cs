/*
 * @lc app=leetcode id=1743 lang=csharp
 *
 * [1743] Restore the Array From Adjacent Pairs
 */

// @lc code=start
public class Solution {
    Dictionary<int, List<int>> graph;
    int[] result;

    public int[] RestoreArray(int[][] adjacentPairs) {
        BuildGraph(adjacentPairs);
        BuildChain(FindHead(), 0, 0);
        return result;
    }

    private void BuildGraph(int[][] adjacentPairs) {
        graph = new();

        foreach (int[] pair in adjacentPairs) {
            AddToGraph(pair);
        }

        result = new int[graph.Count];
    }

    private void AddToGraph(int[] pair) {
        foreach (int node in pair) {
            if (!graph.ContainsKey(node)) graph[node] = new();
        }
        graph[pair[0]].Add(pair[1]);
        graph[pair[1]].Add(pair[0]);
    }

    private int FindHead() {
        foreach (int key in graph.Keys) {
            if (graph[key].Count == 1) return key;
        }
        return 0;
    }

    private void BuildChain(int cur, int prev, int i) {
        result[i] = cur;
        foreach (int next in graph[cur]) {
            if (next != prev) {
                BuildChain(next, cur, i + 1);
            }
        }
    }
}
// @lc code=end

