public class Solution {
    private class Edge {
        public int Index, From, To, Cost;
    }

    private Edge[] map;
    private int nodes;

    public IList<IList<int>> FindCriticalAndPseudoCriticalEdges(int n, int[][] edges) {
        nodes = n;
        map = new Edge[edges.Length];
        for (int i = 0; i < edges.Length; i++) {
            map[i] = new Edge {
                Index = i,
                From = edges[i][0],
                To = edges[i][1],
                Cost = edges[i][2]
            };
        }
        Array.Sort(map, (Edge a, Edge b) => a.Cost.CompareTo(b.Cost));
        int origCost = GetCost();
        List<IList<int>> result = new() {
            new List<int>(),
            new List<int>()
        };
        foreach (Edge edge in map) {
            if (GetCostIgnoring(edge) > origCost) result[0].Add(edge.Index);
            else if (GetCostForcing(edge) == origCost) result[1].Add(edge.Index);
        }
        return result;
    }

    private int GetCostIgnoring(Edge index) {
        return GetCost(index, null);
    }

    private int GetCostForcing(Edge forcing) {
        return GetCost(null, forcing);
    }

    private int GetCost(Edge ignoring = null, Edge forcing = null) {
        int cost = 0;
        UnionFind uf = new(nodes);
        if (forcing != null) {
            uf.Union(forcing.From, forcing.To);
            cost += forcing.Cost;
        }
        foreach (Edge edge in map) {
            if (uf.Count == 1) break;
            if (edge == ignoring || edge == forcing) continue;
            if (uf.Find(edge.From) == uf.Find(edge.To)) continue;
            uf.Union(edge.From, edge.To);
            cost += edge.Cost;
        }
        if (uf.Count > 1) return Int32.MaxValue;
        return cost;
    }
}

public class UnionFind {
    private int[] Root;
    private int[] Size;
    public int Count { get; private set; }
    
    public UnionFind(int size) {
        this.Root = Enumerable.Range(0, size).ToArray();
        this.Size = Enumerable.Repeat(1, size).ToArray();
        this.Count = size;
    }

    public int Find(int n) {
        if (n != Root[n]) {
            Root[n] = Find(Root[n]);
        }
        return Root[n];
    }

    public void Union(int a, int b) {
        int _a = Find(a);
        int _b = Find(b);
        if (_a == _b) return;
        if (Size[_a] < Size[_b]) (_a, _b) = (_b, _a);
        Root[_b] = _a;
        Size[_a] += Size[_b];
        Count--;
    }
}