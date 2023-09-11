/*
 * @lc app=leetcode id=1282 lang=csharp
 *
 * [1282] Group the People Given the Group Size They Belong To
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> GroupThePeople(int[] groupSizes) {
        int max = groupSizes.Max();
        List<List<int>> map = new(max + 1);
        List<IList<int>> result = new();
        for (int i = 0; i <= max; i++) {
            map.Add(new(i));
        }
        for (int i = 0; i < groupSizes.Length; i++) {
            int size = groupSizes[i];
            map[size].Add(i);
            if (map[size].Count == map[size].Capacity) {
                result.Add(new List<int>(map[size]));
                map[size].Clear();
            }
        }
        return result;
    }
}
// @lc code=end

