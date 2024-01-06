/*
 * @lc app=leetcode id=1235 lang=csharp
 *
 * [1235] Maximum Profit in Job Scheduling
 */

// @lc code=start
public class Solution {
    public class Job {
        public int StartTime;
        public int EndTime;
        public int Profit;
    }

    public int JobScheduling(int[] startTime, int[] endTime, int[] profit) {
        List<Job> jobs = new();
        for (int i = 0; i < startTime.Length; i++) {
            jobs.Add(new(){StartTime = startTime[i], EndTime = endTime[i], Profit = profit[i]});
        }
        jobs.Sort((a, b) => { return a.StartTime - b.StartTime; });
        
        int maxProfit = 0;
        PriorityQueue<Job, int> pq = new();
        foreach (Job job in jobs) {
            while (pq.Count > 0 && job.StartTime >= pq.Peek().EndTime) {
                maxProfit = Math.Max(maxProfit, pq.Peek().Profit);
                pq.Dequeue();
            }
            job.Profit += maxProfit;
            pq.Enqueue(job, job.EndTime);
        }

        while (pq.Count > 0) {
            maxProfit = Math.Max(maxProfit, pq.Dequeue().Profit);
        }
        return maxProfit;
    }
}
// @lc code=end

