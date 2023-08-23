public class Solution {
    public string ReorganizeString(string s) {
        int[] freq = new int[26];
        foreach (char c in s) {
            freq[c - 'a']++;
        }
        PriorityQueue<char, int> pq = new();
        for (int i = 0; i < 26; i++) {
            if (freq[i] == 0) continue;
            pq.Enqueue((char)(i + 'a'), -freq[i]);
        }
        StringBuilder result = new();
        while (pq.Count > 0) {
            pq.TryDequeue(out char char1, out int count1);
            if (result.Length == 0 || result[^1] != char1) {
                result.Append(char1);
                count1++;
            }
            else {
                if (!pq.TryDequeue(out char char2, out int count2)) {
                    return String.Empty;
                }
                result.Append(char2);
                count2++;
                if (count2 < 0) pq.Enqueue(char2, count2);
            } 
            if (count1 < 0) pq.Enqueue(char1, count1);
        }
        return result.ToString();
    }
}