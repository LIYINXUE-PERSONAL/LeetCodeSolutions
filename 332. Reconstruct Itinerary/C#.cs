/*
 * @lc app=leetcode id=332 lang=csharp
 *
 * [332] Reconstruct Itinerary
 */

// @lc code=start
public class Solution {
    private string START_LOCATION = "JFK";
    private string PLACE_HOLDER = "...";

    private Dictionary<string, List<string>> flights = new();
    private int tickets = 0;
    private List<string> result = new();

    public IList<string> FindItinerary(IList<IList<string>> tickets) {
        this.tickets = tickets.Count;
        foreach (IList<string> ticket in tickets) {
            if (!flights.ContainsKey(ticket[0])) flights[ticket[0]] = new();
            flights[ticket[0]].Add(ticket[1]);
        }
        foreach (string start in flights.Keys) {
            flights[start].Sort();
        }
        List<string> cur = new();
        cur.Add(START_LOCATION);
        SearchFlight(START_LOCATION, cur);
        return result;
    }

    private bool SearchFlight(string start, List<string> cur) {
        if (cur.Count > tickets) {
            result = cur;
            return true;
        }
        if (!flights.ContainsKey(start)) return false;
        for (int i = 0; i < flights[start].Count; i++) {
            string next = flights[start][i];
            if (next != PLACE_HOLDER) {
                flights[start][i] = PLACE_HOLDER;
                cur.Add(next);
                if (SearchFlight(next, cur)) return true;
                flights[start][i] = next;
                cur.RemoveAt(cur.Count - 1);
            }
        }
        return false;
    }
}
// @lc code=end

