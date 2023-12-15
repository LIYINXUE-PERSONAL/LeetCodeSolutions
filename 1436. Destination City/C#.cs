/*
 * @lc app=leetcode id=1436 lang=csharp
 *
 * [1436] Destination City
 */

// @lc code=start
public class Solution {
    public string DestCity(IList<IList<string>> paths) {
        HashSet<string> dest = new();
        foreach (IList<string> path in paths) {
            dest.Add(path[1]);
        }
        foreach (IList<string> path in paths) {
            dest.Remove(path[0]);
        }
        return dest.ToArray()[0];
    }
}
// @lc code=end

