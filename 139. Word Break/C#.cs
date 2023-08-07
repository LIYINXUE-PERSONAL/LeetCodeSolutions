public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        TrieNode head = new();
        foreach (string word in wordDict) {
            TrieNode cur = head;
            foreach (char c in word) {
                if (!cur.Children.ContainsKey(c)) cur.Children[c] = new();
                cur = cur.Children[c];
            }
            cur.SetWordEnd();
        }
        bool[] dp = new bool[s.Length];
        for (int i = 0; i < s.Length; i++) {
            if (i == 0 || dp[i - 1]) {
                TrieNode cur = head;
                for (int j = i; j < s.Length; j++) {
                    if (!cur.Children.ContainsKey(s[j])) break;
                    cur = cur.Children[s[j]];
                    if (cur.End) dp[j] = true;
                }
            }
        }
        return dp[^1];
    }
}

public class TrieNode {
    public bool End { get; private set; }
    public Dictionary<char, TrieNode> Children { get; private set; }

    public TrieNode(bool end = false) {
        this.End = end;
        this.Children = new(26);
    }

    public void SetWordEnd() {
        this.End = true;
    }
}