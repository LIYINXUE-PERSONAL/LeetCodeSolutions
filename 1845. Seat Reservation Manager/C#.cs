/*
 * @lc app=leetcode id=1845 lang=csharp
 *
 * [1845] Seat Reservation Manager
 */

// @lc code=start
public class SeatManager {
    int min;
    PriorityQueue<int, int> unreserved;

    public SeatManager(int n) {
        min = 1;
        unreserved = new();
    }
    
    public int Reserve() {
        if (unreserved.Count == 0) return min++;
        return unreserved.Dequeue();
    }
    
    public void Unreserve(int seatNumber) {
        unreserved.Enqueue(seatNumber, seatNumber);
    }
}


/**
 * Your SeatManager object will be instantiated and called as such:
 * SeatManager obj = new SeatManager(n);
 * int param_1 = obj.Reserve();
 * obj.Unreserve(seatNumber);
 */
// @lc code=end

