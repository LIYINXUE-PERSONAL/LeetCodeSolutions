public class Solution {
    public IList<string> FullJustify(string[] words, int maxWidth) {
        List<string> wrapped = WrapWords(words, maxWidth);
        for (int i = 0; i < wrapped.Count - 1; i++) {
            wrapped[i] = EvenlyDistribute(wrapped[i], maxWidth);
        }
        wrapped[^1] += new string(' ', maxWidth - wrapped[^1].Length);
        return wrapped;
    }

    private List<string> WrapWords(string[] words, int maxWidth) {
        List<string> result = new();
        foreach (string word in words) {
            if (result.Count == 0 || result[^1].Length + word.Length >= maxWidth) {
                result.Add(String.Empty);
            }
            if (result[^1].Length > 0) result[^1] += " ";
            result[^1] += word;
        }
        return result;
    }

    private string EvenlyDistribute(string line, int width) {
        string newLine = String.Empty;
        string[] words = line.Split(' ');
        int spaces = width - (line.Length - (words.Length - 1));
        if (words.Length == 1) return line + new string(' ', spaces);
        newLine = words[^1];
        int rem = words.Length - 1;
        for (int i = words.Length - 2; i >= 0; i--) {
            int count = spaces / rem;
            spaces -= count;
            rem--;
            newLine = words[i] + new string(' ', count) + newLine;
        }
        return newLine;
    }
}