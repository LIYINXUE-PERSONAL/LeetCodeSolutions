public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        if (k == 1) return nums;
        if (k == nums.Length) return new int[1]{nums.Max()};
        List<int> res = new();
        LinkedList<int> deque = new();
        for (int i = 0; i < k - 1; i++) {
            while (deque.Count > 0 && nums[deque.Last.Value] <= nums[i]) deque.RemoveLast();
            deque.AddLast(i);
        }
        for (int i = k - 1; i < nums.Length; i++) {
            if (deque.First.Value == i - k) deque.RemoveFirst();
            while (deque.Count > 0 && nums[deque.Last.Value] <= nums[i]) deque.RemoveLast();
            deque.AddLast(i);
            res.Add(nums[deque.First.Value]);
        }
        return res.ToArray();
    }
}