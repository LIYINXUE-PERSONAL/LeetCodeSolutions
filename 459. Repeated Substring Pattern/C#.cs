public class Solution {
    public bool RepeatedSubstringPattern(string s) {
        string t = String.Empty;
        for (int i = 0; i < s.Length / 2; i++) {
            t += s[i];
            if (s.Length % (i + 1) == 0) {
                if (s == t.Repeat(s.Length / (i + 1))) return true;
            }
        }
        return false;
    }

    public bool RepeatedSubstringPattern(string s) {
        return (s + s)[1..^1].Contains(s);
    }
}

public static class StringExtensions
{
    public static string Repeat(this string s, int n)
        => new StringBuilder(s.Length * n).Insert(0, s, n).ToString();
}