public class Solution {
    public int[] SortItems(int n, int m, int[] group, IList<IList<int>> beforeItems) {
        int totalGroup = m;
        for (int i = 0; i < group.Length; i++) {
            if (group[i] == -1) group[i] = totalGroup++;
        }

        List<int>[] itemGraph = InitializeGraph(n);
        int[] itemIndegree = new int[n];
        List<int>[] groupGraph = InitializeGraph(totalGroup);
        int[] groupIndegree = new int[totalGroup];

        for (int c = 0; c < n; c++) {
            foreach (int p in beforeItems[c]) {
                itemGraph[p].Add(c);
                itemIndegree[c]++;
                if (group[c] != group[p]) {
                    groupGraph[group[p]].Add(group[c]);
                    groupIndegree[group[c]]++;
                }
            }
        }
        
        List<int> itemOrder = TopoSort(itemGraph, itemIndegree);
        List<int> groupOrder = TopoSort(groupGraph, groupIndegree);

        if (itemOrder.Count == 0 || groupOrder.Count == 0) return new int[0];

        List<int>[] orderedGroups = InitializeGraph(totalGroup);
        foreach (int i in itemOrder) {
            orderedGroups[group[i]].Add(i);
        }

        List<int> result = new();
        foreach (int g in groupOrder) {
            result.AddRange(orderedGroups[g]);
        }
        return result.ToArray();
    }

    private List<int>[] InitializeGraph(int count) {
        List<int>[] result = new List<int>[count];
        for (int i = 0; i < count; i++) {
            result[i] = new();
        }
        return result;
    }

    private List<int> TopoSort(List<int>[] graph, int[] indegree) {
        List<int> order = new();
        Queue<int> queue = new();
        for (int i = 0; i < graph.Length; i++) {
            if (indegree[i] == 0) {
                queue.Enqueue(i);
            }
        }
        while (queue.Count > 0) {
            order.Add(queue.Dequeue());
            foreach (int next in graph[order[^1]]) {
                if (--indegree[next] == 0) queue.Enqueue(next);
            }
        }
        return order.Count == graph.Length ? order : new();
    }
}