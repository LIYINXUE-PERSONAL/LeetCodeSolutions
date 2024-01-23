/*
 * @lc app=leetcode id=1239 lang=csharp
 *
 * [1239] Maximum Length of a Concatenated String with Unique Characters
 */

// @lc code=start
public class Solution {
    private int len;
    private IList<string> arr;

    public int MaxLength(IList<string> arr) {
        this.len = 0;
        this.arr = arr;

        Helper(new(), 0);

        return len;
    }

    private void Helper(HashSet<char> set, int index) {
        if (index >= arr.Count) {
            len = Math.Max(len, set.Count);
            return;
        }
        Helper(set, index + 1);
        HashSet<char> temp = new();
        foreach (char c in arr[index]) {
            if (set.Contains(c) || temp.Contains(c)) return;
            temp.Add(c);
        }
        set.UnionWith(temp);
        Helper(set, index + 1);
        foreach (char c in arr[index]) {
            set.Remove(c);
        }
    }
}
// @lc code=end

