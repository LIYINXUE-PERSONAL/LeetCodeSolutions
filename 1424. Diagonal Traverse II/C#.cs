/*
 * @lc app=leetcode id=1424 lang=csharp
 *
 * [1424] Diagonal Traverse II
 */

// @lc code=start
public class Solution {
    private class Pos {
        public int x, y;
        
        public Pos(int x, int y) { this.x = x; this.y = y; }
    }

    private IList<IList<int>> nums;

    public int[] FindDiagonalOrder(IList<IList<int>> nums) {
        this.nums = nums;
        List<int> result = new();
        Queue<Pos> queue = new();
        queue.Enqueue(new(0,0));
        while (queue.Count > 0) {
            Pos cur = queue.Dequeue();
            result.Add(nums[cur.x][cur.y]);
            if (cur.y == 0 && Exists(cur.x + 1, cur.y)) {
                queue.Enqueue(new(cur.x + 1, cur.y));
            }
            if (Exists(cur.x, cur.y + 1)) {
                queue.Enqueue(new(cur.x, cur.y + 1));
            }
        }
        return result.ToArray();
    }

    private bool Exists(int x, int y) {
        return x < nums.Count && y < nums[x].Count;
    }
}
// @lc code=end

