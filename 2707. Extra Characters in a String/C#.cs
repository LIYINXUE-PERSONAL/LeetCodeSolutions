/*
 * @lc app=leetcode id=2707 lang=csharp
 *
 * [2707] Extra Characters in a String
 */

// @lc code=start
public class Solution {
    public int MinExtraChar(string s, string[] dictionary) {
        TrieNode head = new();
        foreach (string word in dictionary) {
            head.SetWord(word);
        }
        int[] dp = new int[s.Length + 1];
        for (int left = s.Length - 1; left >= 0; left--) {
            dp[left] = dp[left + 1] + 1;
            TrieNode cur = head;
            for (int right = left; right < s.Length; right++){
                if (!cur.Children.ContainsKey(s[right])) break;
                cur = cur.Children[s[right]];
                if (cur.End) dp[left] = Math.Min(dp[left], dp[right + 1]);
            }
        }
        return dp[0];
    }
}

public class TrieNode {
    public Dictionary<char, TrieNode> Children { get; private set; }
    public bool End { get; private set; }

    public TrieNode() {
        Children = new(26);
        End = false;
    }

    public void SetEnd() {
        End = true;
    }

    public void SetWord(string word, int index = 0) {
        char c = word[index];
        if (!Children.ContainsKey(c)) Children[c] = new();
        index++;
        if (index < word.Length) Children[c].SetWord(word, index);
        else Children[c].SetEnd();
    }
}
// @lc code=end

