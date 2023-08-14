public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        PriorityQueue<int, int> pq = new(k);
        foreach (int n in nums) {
            int smaller = n;
            if (pq.Count == k) {
                smaller = Math.Max(smaller, pq.Dequeue());
            }
            pq.Enqueue(smaller, smaller);
        }
        return pq.Peek();
    }
}