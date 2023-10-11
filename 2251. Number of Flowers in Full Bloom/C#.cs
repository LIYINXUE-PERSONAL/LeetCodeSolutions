/*
 * @lc app=leetcode id=2251 lang=csharp
 *
 * [2251] Number of Flowers in Full Bloom
 */

// @lc code=start
public class Solution {
    public int[] FullBloomFlowers(int[][] flowers, int[] people) {
        List<KeyValuePair<int, int>> changes = new();
        foreach (int[] flower in flowers) {
            changes.Add(new(flower[0], 1));
            changes.Add(new(flower[1] + 1, -1));
        }
        changes.Sort((a, b) => a.Key.CompareTo(b.Key));
        Stack<KeyValuePair<int, int>> pSum = new();
        foreach (KeyValuePair<int, int> change in changes) {
            if (pSum.Count == 0) {
                pSum.Push(new(change.Key, change.Value));
            }
            else if (pSum.Peek().Key == change.Key) {
                pSum.Push(new(change.Key, pSum.Pop().Value + change.Value));
            }
            else {
                pSum.Push(new(change.Key, pSum.Peek().Value + change.Value));
            }
        }
        List<KeyValuePair<int, int>> blooms = pSum.ToList();
        blooms.Reverse();
        ComparerOnKey comparer = new();
        int[] result = new int[people.Length];
        for (int i = 0; i < people.Length; i++) {
            int bi = blooms.BinarySearch(new(people[i], 0), comparer);
            if (bi < 0) bi = ~bi - 1;
            result[i] = bi < 0 ? 0 : blooms[bi].Value;
        }
        return result;
    }

    public class ComparerOnKey: IComparer<KeyValuePair<int, int>> {
        public int Compare(KeyValuePair<int, int> a, KeyValuePair<int, int> b) {
            return a.Key.CompareTo(b.Key);
        } 
    }
}
// @lc code=end

