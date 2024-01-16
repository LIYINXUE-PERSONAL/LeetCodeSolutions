/*
 * @lc app=leetcode id=380 lang=csharp
 *
 * [380] Insert Delete GetRandom O(1)
 */

// @lc code=start
public class RandomizedSet {
    private Random rnd;
    private List<int> list;
    private Dictionary<int, int> index;

    public RandomizedSet() {
        rnd = new();
        list = new();
        index = new();
    }
    
    public bool Insert(int val) {
        if (index.ContainsKey(val)) return false;
        index[val] = list.Count;
        list.Add(val);
        return true;
    }
    
    public bool Remove(int val) {
        if (!index.ContainsKey(val)) return false;
        CopyLastTo(index[val]);
        list.RemoveAt(list.Count - 1);
        index.Remove(val);
        return true;
    }

    private void CopyLastTo(int i) {
        list[i] = list[^1];
        index[list[i]] = i;
    }
    
    public int GetRandom() {
        return list[rnd.Next(list.Count)];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */
// @lc code=end

