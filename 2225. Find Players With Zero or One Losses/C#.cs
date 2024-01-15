/*
 * @lc app=leetcode id=2225 lang=csharp
 *
 * [2225] Find Players With Zero or One Losses
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> FindWinners(int[][] matches) {
        HashSet<int> players = new();
        Dictionary<int, HashSet<int>> lost = new();
        lost[0] = new();
        lost[1] = new();

        foreach (int[] match in matches) {
            int winner = match[0], loser = match[1];
            if (!players.Contains(winner)) {
                lost[0].Add(winner);
                players.Add(winner);
            }
            if (!players.Contains(loser)) {
                lost[1].Add(loser);
                players.Add(loser);
            }
            else if (lost[0].Contains(loser)) {
                lost[0].Remove(loser);
                lost[1].Add(loser);
            }
            else if (lost[1].Contains(loser)) {
                lost[1].Remove(loser);
            }
        }

        List<IList<int>> result = new();
        result.Add(lost[0].OrderBy(a=>a).ToList());
        result.Add(lost[1].OrderBy(a=>a).ToList());
        return result;
    }
}
// @lc code=end

