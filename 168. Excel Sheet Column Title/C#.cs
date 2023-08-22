public class Solution {
    public string ConvertToTitle(int columnNumber) {
        string s = String.Empty;
        while (columnNumber > 0) {
            columnNumber--;
            s = (char)('A' + columnNumber % 26) + s;
            columnNumber /= 26;
        }
        return s;
    }
}